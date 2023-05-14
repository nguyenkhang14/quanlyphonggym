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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsvalidUser(txtUseName.Text, txtPassWord.Text))
            {
                TrangChu tc = new TrangChu();
                tc.Show();
            }
            else
            {
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu");
            }
        }
        private bool IsvalidUser(string userName, string password)

        {
            QLPGDataContext taikhoan = new QLPGDataContext();

            var q = from p in taikhoan.Accounts
                    where p.ID == txtUseName.Text
                    && p.Pass == txtPassWord.Text
                    select p;
            if (q.Any())

            {
                return true;

            }
            else
            {
                return false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
