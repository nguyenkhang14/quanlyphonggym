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
using System.Data.Sql;
using System.Data.SqlClient;
namespace BaiTapCuoiKy
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=DESKTOP-QUF1NBA;Initial Catalog=QLPG;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd;

            //create a command
            string query = "SELECT COUNT(TenKH) FROM KHACHHANG";
            try
            {
                con.Open();

                cmd = new SqlCommand(query, con);

                //doc from tu database
                Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                lblKhachHang.Text = " " + rows_count.ToString() + " Thành Viên";

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            // dem dungcu trong phong
            string query1 = "SELECT COUNT(MaDC) FROM DUNGCU";
            try
            {
                con.Open();

                cmd = new SqlCommand(query1, con);

                //read from db
                Int32 rows_count1 = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                //Display data on the page
                lblDungCu.Text = " " + rows_count1.ToString() + " Dụng Cụ";

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
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
