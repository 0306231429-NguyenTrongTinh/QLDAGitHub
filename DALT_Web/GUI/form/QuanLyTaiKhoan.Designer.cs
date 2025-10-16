namespace GUI.form
{
    partial class QuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyTaiKhoan));
            this.dgv_taiKhoan = new System.Windows.Forms.DataGridView();
            this.coll_MaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_Quyen = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_themTaiKhoan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaTaiKhoan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_suaTaiKhoan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_lamMoiDS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taiKhoan)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_taiKhoan
            // 
            this.dgv_taiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_taiKhoan.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_taiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coll_MaTK,
            this.coll_MaNhanVien,
            this.coll_TenDangNhap,
            this.coll_MatKhau,
            this.coll_Quyen});
            this.dgv_taiKhoan.Location = new System.Drawing.Point(12, 30);
            this.dgv_taiKhoan.Name = "dgv_taiKhoan";
            this.dgv_taiKhoan.RowHeadersWidth = 51;
            this.dgv_taiKhoan.RowTemplate.Height = 24;
            this.dgv_taiKhoan.Size = new System.Drawing.Size(1370, 198);
            this.dgv_taiKhoan.TabIndex = 39;
            // 
            // coll_MaTK
            // 
            this.coll_MaTK.HeaderText = "Mã Tài Khoản";
            this.coll_MaTK.MinimumWidth = 6;
            this.coll_MaTK.Name = "coll_MaTK";
            // 
            // coll_MaNhanVien
            // 
            this.coll_MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.coll_MaNhanVien.MinimumWidth = 6;
            this.coll_MaNhanVien.Name = "coll_MaNhanVien";
            // 
            // coll_TenDangNhap
            // 
            this.coll_TenDangNhap.HeaderText = "Tên Đăng Nhập ";
            this.coll_TenDangNhap.MinimumWidth = 6;
            this.coll_TenDangNhap.Name = "coll_TenDangNhap";
            // 
            // coll_MatKhau
            // 
            this.coll_MatKhau.HeaderText = "Mật Khẩu ";
            this.coll_MatKhau.MinimumWidth = 6;
            this.coll_MatKhau.Name = "coll_MatKhau";
            // 
            // coll_Quyen
            // 
            this.coll_Quyen.HeaderText = "Quyền";
            this.coll_Quyen.MinimumWidth = 6;
            this.coll_Quyen.Name = "coll_Quyen";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_themTaiKhoan,
            this.toolStripSeparator,
            this.tsb_xoaTaiKhoan,
            this.toolStripSeparator2,
            this.tsb_suaTaiKhoan,
            this.toolStripSeparator3,
            this.ts_lamMoiDS,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1410, 27);
            this.toolStrip1.TabIndex = 41;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_themTaiKhoan
            // 
            this.tsb_themTaiKhoan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_themTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("tsb_themTaiKhoan.Image")));
            this.tsb_themTaiKhoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_themTaiKhoan.Name = "tsb_themTaiKhoan";
            this.tsb_themTaiKhoan.Size = new System.Drawing.Size(29, 24);
            this.tsb_themTaiKhoan.Text = "&Thêm Tài Khoản ";
            this.tsb_themTaiKhoan.Click += new System.EventHandler(this.tsb_themTaiKhoan_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_xoaTaiKhoan
            // 
            this.tsb_xoaTaiKhoan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_xoaTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("tsb_xoaTaiKhoan.Image")));
            this.tsb_xoaTaiKhoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_xoaTaiKhoan.Name = "tsb_xoaTaiKhoan";
            this.tsb_xoaTaiKhoan.Size = new System.Drawing.Size(29, 24);
            this.tsb_xoaTaiKhoan.Text = "&Xóa Tài Khoản";
            this.tsb_xoaTaiKhoan.Click += new System.EventHandler(this.tsb_xoaTaiKhoan_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_suaTaiKhoan
            // 
            this.tsb_suaTaiKhoan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_suaTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("tsb_suaTaiKhoan.Image")));
            this.tsb_suaTaiKhoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_suaTaiKhoan.Name = "tsb_suaTaiKhoan";
            this.tsb_suaTaiKhoan.Size = new System.Drawing.Size(29, 24);
            this.tsb_suaTaiKhoan.Text = "&Sửa Tài Khoản";
            this.tsb_suaTaiKhoan.Click += new System.EventHandler(this.tsb_suaTaiKhoan_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // ts_lamMoiDS
            // 
            this.ts_lamMoiDS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_lamMoiDS.Image = ((System.Drawing.Image)(resources.GetObject("ts_lamMoiDS.Image")));
            this.ts_lamMoiDS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_lamMoiDS.Name = "ts_lamMoiDS";
            this.ts_lamMoiDS.Size = new System.Drawing.Size(29, 24);
            this.ts_lamMoiDS.Text = "&Làm Mới Danh Sách";
            this.ts_lamMoiDS.Click += new System.EventHandler(this.ts_lamMoiDS_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 683);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_taiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyTaiKhoan";
            this.Text = "QuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taiKhoan)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_taiKhoan;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_themTaiKhoan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsb_xoaTaiKhoan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_suaTaiKhoan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ts_lamMoiDS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_MatKhau;
        private System.Windows.Forms.DataGridViewComboBoxColumn coll_Quyen;
    }
}