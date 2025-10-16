namespace GUI.form
{
    partial class ThemTK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemTK));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_quyen = new System.Windows.Forms.TextBox();
            this.btn_themNV = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_maNhanVien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_XnMk = new System.Windows.Forms.Button();
            this.btn_Mk = new System.Windows.Forms.Button();
            this.txt_xacNhanMk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_themTK = new System.Windows.Forms.Button();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txt_taiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.txt_quyen);
            this.panel1.Controls.Add(this.btn_themNV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbb_maNhanVien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_XnMk);
            this.panel1.Controls.Add(this.btn_Mk);
            this.panel1.Controls.Add(this.txt_xacNhanMk);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_themTK);
            this.panel1.Controls.Add(this.txt_mk);
            this.panel1.Controls.Add(this.txt_taiKhoan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(298, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 410);
            this.panel1.TabIndex = 20;
            // 
            // txt_quyen
            // 
            this.txt_quyen.Enabled = false;
            this.txt_quyen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quyen.Location = new System.Drawing.Point(219, 138);
            this.txt_quyen.Multiline = true;
            this.txt_quyen.Name = "txt_quyen";
            this.txt_quyen.ReadOnly = true;
            this.txt_quyen.Size = new System.Drawing.Size(210, 30);
            this.txt_quyen.TabIndex = 40;
            // 
            // btn_themNV
            // 
            this.btn_themNV.Location = new System.Drawing.Point(340, 362);
            this.btn_themNV.Name = "btn_themNV";
            this.btn_themNV.Size = new System.Drawing.Size(136, 36);
            this.btn_themNV.TabIndex = 39;
            this.btn_themNV.Text = "Thêm Nhân Viên";
            this.btn_themNV.UseVisualStyleBackColor = true;
            this.btn_themNV.Click += new System.EventHandler(this.btn_themNV_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 23);
            this.label6.TabIndex = 38;
            this.label6.Text = "Mã Nhân Viên";
            // 
            // cbb_maNhanVien
            // 
            this.cbb_maNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_maNhanVien.FormattingEnabled = true;
            this.cbb_maNhanVien.Location = new System.Drawing.Point(216, 93);
            this.cbb_maNhanVien.Name = "cbb_maNhanVien";
            this.cbb_maNhanVien.Size = new System.Drawing.Size(210, 24);
            this.cbb_maNhanVien.TabIndex = 37;
            this.cbb_maNhanVien.SelectedValueChanged += new System.EventHandler(this.cbb_maNhanVien_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Quyền";
            // 
            // btn_XnMk
            // 
            this.btn_XnMk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_XnMk.Location = new System.Drawing.Point(448, 310);
            this.btn_XnMk.Name = "btn_XnMk";
            this.btn_XnMk.Size = new System.Drawing.Size(28, 28);
            this.btn_XnMk.TabIndex = 34;
            this.btn_XnMk.UseVisualStyleBackColor = true;
            this.btn_XnMk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_XnMk_MouseDown);
            this.btn_XnMk.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_XnMk_MouseUp);
            // 
            // btn_Mk
            // 
            this.btn_Mk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Mk.Location = new System.Drawing.Point(448, 251);
            this.btn_Mk.Name = "btn_Mk";
            this.btn_Mk.Size = new System.Drawing.Size(28, 28);
            this.btn_Mk.TabIndex = 30;
            this.btn_Mk.UseVisualStyleBackColor = true;
            this.btn_Mk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Mk_MouseDown);
            this.btn_Mk.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Mk_MouseUp);
            // 
            // txt_xacNhanMk
            // 
            this.txt_xacNhanMk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xacNhanMk.Location = new System.Drawing.Point(219, 308);
            this.txt_xacNhanMk.Multiline = true;
            this.txt_xacNhanMk.Name = "txt_xacNhanMk";
            this.txt_xacNhanMk.Size = new System.Drawing.Size(210, 30);
            this.txt_xacNhanMk.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Xác nhận Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thêm Tài Khoản";
            // 
            // btn_themTK
            // 
            this.btn_themTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_themTK.Location = new System.Drawing.Point(93, 362);
            this.btn_themTK.Name = "btn_themTK";
            this.btn_themTK.Size = new System.Drawing.Size(185, 36);
            this.btn_themTK.TabIndex = 5;
            this.btn_themTK.Text = "Thêm Tài Khoản";
            this.btn_themTK.UseVisualStyleBackColor = true;
            this.btn_themTK.Click += new System.EventHandler(this.btn_themTK_Click);
            // 
            // txt_mk
            // 
            this.txt_mk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mk.Location = new System.Drawing.Point(219, 249);
            this.txt_mk.Multiline = true;
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(210, 30);
            this.txt_mk.TabIndex = 3;
            // 
            // txt_taiKhoan
            // 
            this.txt_taiKhoan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taiKhoan.Location = new System.Drawing.Point(219, 192);
            this.txt_taiKhoan.Multiline = true;
            this.txt_taiKhoan.Name = "txt_taiKhoan";
            this.txt_taiKhoan.Size = new System.Drawing.Size(210, 30);
            this.txt_taiKhoan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // ThemTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 410);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemTK";
            this.Text = "ThemTK";
            this.Load += new System.EventHandler(this.ThemTK_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_XnMk;
        private System.Windows.Forms.Button btn_Mk;
        private System.Windows.Forms.TextBox txt_xacNhanMk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_themTK;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.TextBox txt_taiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_maNhanVien;
        private System.Windows.Forms.Button btn_themNV;
        private System.Windows.Forms.TextBox txt_quyen;
    }
}