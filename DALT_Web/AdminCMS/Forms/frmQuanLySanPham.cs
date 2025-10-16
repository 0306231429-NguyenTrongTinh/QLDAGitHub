using System;
using System.Windows.Forms;

namespace QLBH.Forms
{
    public partial class frmQuanLySanPham : Form
    {
        public frmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = new[]
            {
                new { MaSP = "SP01", TenSP = "Điện thoại", DonGia = 5000000 },
                new { MaSP = "SP02", TenSP = "Laptop", DonGia = 15000000 }
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm sản phẩm thành công!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa sản phẩm thành công!");
        }
    }
}
