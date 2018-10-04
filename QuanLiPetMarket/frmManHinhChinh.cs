using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiPetMarket
{
    public partial class frmManHinhChinh : Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            dn.ShowDialog();
        }

        private void btLienhe_Click(object sender, EventArgs e)
        {
            frmLienHe lh = new frmLienHe();
            lh.ShowDialog();
        }
    }
}
