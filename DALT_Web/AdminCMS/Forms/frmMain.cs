using System;
using System.Windows.Forms;

namespace QLBH.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Xin chào, Admin!";
        }

        private void menuUser_Click(object sender, EventArgs e)
        {
            frmQuanLyUser f = new frmQuanLyUser();
            f.ShowDialog();
        }

        private void menuSanPham_Click(object sender, EventArgs e)
        {
            frmQuanLySanPham f = new frmQuanLySanPham();
            f.ShowDialog();
        }

        private void menuDonHang_Click(object sender, EventArgs e)
        {
            frmQuanLyDonHang f = new frmQuanLyDonHang();
            f.ShowDialog();
        }

        private void menuThongKe_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu f = new frmThongKeDoanhThu();
            f.ShowDialog();
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
