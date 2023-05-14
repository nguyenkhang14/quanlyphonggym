using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Globalization;

namespace BaiTapCuoiKy
{
    public partial class QLKH : Form
    {
        public QLKH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void load()
        {
            QLPGDataContext qlpg = new QLPGDataContext();
            dataGridView1.DataSource = qlpg.KHACHHANGs.Select(k => k);
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if(TxtTenKH.Text == "" )
            {
                MessageBox.Show("Thiếu Tên Khách ");
            }
            if(TxtMaKH.Text =="")
            {
                MessageBox.Show("Thiếu Mã Khách Hàng");
            }            
            try
            {
                using (QLPGDataContext db = new QLPGDataContext())
                {
                    KHACHHANG kh = new KHACHHANG();
                    kh.TenKH = TxtTenKH.Text;
                    kh.MaKH = Convert.ToInt32(TxtMaKH.Text);
                    kh.NgayDK = dt_DateTime.Value;
                    kh.GioiTinh = cbGioiTinh.Text;
                    kh.GoiDK = Convert.ToInt32(cbGoi.Text);
                    db.KHACHHANGs.InsertOnSubmit(kh);
                    db.SubmitChanges();
                    load();
                }
            }
            catch
            {
                MessageBox.Show("Trùng hoặc thiếu Mã Khách");
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            load();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            using (QLPGDataContext db = new QLPGDataContext())
            {
                string id = dataGridView1.SelectedCells[0].OwningRow.Cells["MaKH"].Value.ToString();
                KHACHHANG delete = db.KHACHHANGs.Where(k => k.MaKH.Equals(id)).SingleOrDefault();
                db.KHACHHANGs.DeleteOnSubmit(delete);
                db.SubmitChanges();
                load();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (QLPGDataContext db = new QLPGDataContext())
            {
                dataGridView1.DataSource = db.KHACHHANGs.Where(k => k.MaKH.Equals(TxtTim.Text));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                TxtTenKH.Text = row.Cells[0].Value.ToString();
                TxtMaKH.Text = row.Cells[1].Value.ToString();
                
                cbGioiTinh.Text = row.Cells[4].Value.ToString();
                cbGoi.Text = row.Cells[3].Value.ToString();
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            using (QLPGDataContext db = new QLPGDataContext())
            {            
                KHACHHANG edit = db.KHACHHANGs.Where(k => k.MaKH.Equals(TxtMaKH.Text)).SingleOrDefault();
                edit.TenKH = TxtTenKH.Text;
                edit.GioiTinh = cbGioiTinh.Text;
                edit.NgayDK = dt_DateTime.Value;
                edit.GoiDK = Convert.ToInt32(cbGoi.Text);
                db.SubmitChanges();
                load();
                
            }
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            this.Hide();
            tc.ShowDialog();
        }
    }
}
