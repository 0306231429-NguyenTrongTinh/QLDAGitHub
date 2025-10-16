using System;
using System.Windows.Forms;

namespace QLBH.Forms
{
    public partial class frmQuanLyUser : Form
    {
        public frmQuanLyUser()
        {
            InitializeComponent();
        }

        private void frmQuanLyUser_Load(object sender, EventArgs e)
        {
            dgvUser.DataSource = new[]
            {
                new { ID = 1, Username = "admin", Role = "Quản trị viên" },
                new { ID = 2, Username = "user1", Role = "Nhân viên" }
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm người dùng thành công!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa người dùng thành công!");
        }
    }
}
