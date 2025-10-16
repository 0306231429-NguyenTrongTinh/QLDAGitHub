using System;
using System.Windows.Forms;

namespace QLBH.Forms
{
    public partial class frmQuanLyDonHang : Form
    {
        public frmQuanLyDonHang()
        {
            InitializeComponent();
        }

        private void frmQuanLyDonHang_Load(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = new[]
            {
                new { MaDH = "DH01", TenKH = "Nguyễn Văn A", TongTien = 2000000 },
                new { MaDH = "DH02", TenKH = "Trần Thị B", TongTien = 3500000 }
            };
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xem chi tiết đơn hàng!");
        }
    }
}
