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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLKH qlkh = new QLKH();
            this.Hide();
            qlkh.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLDC qldc = new QLDC();
            this.Hide();
            qldc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            this.Hide();
            tk.ShowDialog();
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }
    }
}
