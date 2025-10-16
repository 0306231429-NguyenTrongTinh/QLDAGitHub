using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Linq.Expressions;
using GUI.form;

namespace GUI
{
    public partial class Login: Form
    {
        TaiKhoanBLL tkB = new TaiKhoanBLL();

        TaiKhoanDTO tk = new TaiKhoanDTO();
        public Login()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            

            txt_user.Text = "Your usename";
            txt_user.ForeColor = Color.Gray;

            txt_pass.Text = "Your password";
            txt_pass.ForeColor = Color.Gray;
            txt_pass.Multiline = false;
            txt_pass.UseSystemPasswordChar = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            tk.TenDangNhap = txt_user.Text;
            tk.MatKhau = txt_pass.Text;
            List<string> getUser = tkB.checkLoginBLL(tk);


            switch(getUser[0]){
                case "rq_tk":
                    {
                        MessageBox.Show("Tài khoản không được bỏ trống!", "Thông báo");
                        return;
                    }
                case "rq_pass":
                    {
                        MessageBox.Show("Mật khẩu không được bỏ trống!", "Thông báo");
                        return;
                    }
                case "Tai khoan hoac mat khau khong chinh xac":
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo");
                        return;
                    }
            }

            if (getUser[0] == "Admin")
            {
                
                MessageBox.Show("Admin đăng nhập thành công ", "Thông báo");
                homePage hp = new homePage(getUser[0], getUser[1], getUser[2], getUser[3]);
                this.Hide();
                hp.ShowDialog();
                this.Close();
            }else if(getUser[0] == "NhanVien")
            {
                MessageBox.Show("Nhân viên đăng nhập thành công ", "Thông báo");
                homePage hp = new homePage(getUser[0], getUser[1], getUser[2], getUser[3]);
                this.Hide();
                hp.ShowDialog();
                this.Close();
            }
            else if (getUser[0] == "QuanLy")
            {
                MessageBox.Show("Quản lý đăng nhập thành công ", "Thông báo");
                homePage hp = new homePage(getUser[0], getUser[1], getUser[2], getUser[3]);
                this.Hide();
                hp.ShowDialog();
                this.Close();
            }

        }

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showPass.Checked)
            {
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        


        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_user.Text))
            {
                txt_user.Text = "Your usename";
                txt_user.ForeColor = Color.Gray;
            }
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "Your usename")
            {
                txt_user.Clear();
                txt_user.ForeColor = Color.Black;
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Your password")
            {
                txt_pass.Clear();
                txt_pass.ForeColor = Color.Black;
                if (cb_showPass.Checked)
                {
                    txt_pass.UseSystemPasswordChar = false;
                }
                else
                {
                    txt_pass.UseSystemPasswordChar = true;
                }
                
            }
            
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_pass.Text))
            {
                txt_pass.Text = "Your password";
                txt_pass.ForeColor = Color.Gray;
                txt_pass.UseSystemPasswordChar = false;
            }
        }

        

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }
    }
}
