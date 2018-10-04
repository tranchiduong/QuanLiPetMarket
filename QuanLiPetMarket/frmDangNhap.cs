using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QuanLiPetMarket
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLPetMarket;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtID.Text;
                string mk = txtPW.Text;
                string sql = " Select * from TaiKhoanNhanVien where TaiKhoan = '" + tk + "' and MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dt = cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMenu frmMenu = new frmMenu();
                    frmMenu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }

        }

        private void checkShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPW.Checked)
            {
                txtPW.UseSystemPasswordChar = true;
            }
            else
            {
                txtPW.UseSystemPasswordChar = false;
            }
        }
    }
}
