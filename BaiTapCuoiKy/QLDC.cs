using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapCuoiKy
{
    public partial class QLDC : Form
    {
        public QLDC()
        {
            InitializeComponent();
        }
        void load()
        {
            QLPGDataContext qlpg = new QLPGDataContext();
            dataGridView1.DataSource = qlpg.DUNGCUs.Select(k => k);
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            load();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if(TxtTenDC.Text =="")
            {
                MessageBox.Show("Thiếu Tên Dụng Cụ");
            }
            try
            {
                using (QLPGDataContext db = new QLPGDataContext())
                {
                    DUNGCU kh = new DUNGCU();
                    kh.TenDC = TxtTenDC.Text;
                    kh.MaDC = Convert.ToInt32(TxtMaDC.Text);
                    kh.NgayNhapDC = dtNgayNhap.Value;
                    kh.Soluong = Convert.ToInt32(cbSoLuong.Text);
                    db.DUNGCUs.InsertOnSubmit(kh);
                    db.SubmitChanges();
                    load();
                }
            }
            catch
            {
                MessageBox.Show("Thiếu hoặc Trùng Mã Dụng Cụ");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            using (QLPGDataContext db = new QLPGDataContext())
            {
                string id = dataGridView1.SelectedCells[0].OwningRow.Cells["MaDC"].Value.ToString();
                DUNGCU delete = db.DUNGCUs.Where(k => k.MaDC.Equals(id)).SingleOrDefault();
                db.DUNGCUs.DeleteOnSubmit(delete);
                db.SubmitChanges();
                load();
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            using (QLPGDataContext db = new QLPGDataContext())
            {

                DUNGCU edit = db.DUNGCUs.Where(k => k.MaDC.Equals(TxtMaDC.Text)).SingleOrDefault();
                edit.TenDC = TxtTenDC.Text;
                edit.NgayNhapDC = dtNgayNhap.Value;
                edit.Soluong = Convert.ToInt32(cbSoLuong.Text);               
                db.SubmitChanges();
                load();
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            using (QLPGDataContext db = new QLPGDataContext())
            {
                dataGridView1.DataSource = db.DUNGCUs.Where(k => k.MaDC.Equals(TxtTimKiem.Text));
                //dataGridView1.DataSource = db.DUNGCUs.Where(p => p.TenDC.Equals(TxtTenDC.Text));            
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                TxtTenDC.Text = row.Cells[0].Value.ToString();
                TxtMaDC.Text = row.Cells[1].Value.ToString();
                cbSoLuong.Text = row.Cells[3].Value.ToString();
                
            }
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            TrangChu tc1 = new TrangChu();
            this.Hide();
            tc1.ShowDialog();
        }
    }
}
