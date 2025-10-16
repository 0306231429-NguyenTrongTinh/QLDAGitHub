namespace GUI.form
{
    partial class LoaiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiSanPham));
            this.dgv_LSP = new System.Windows.Forms.DataGridView();
            this.coll_maLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_tenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_themLSP = new System.Windows.Forms.ToolStripButton();
            this.ts_1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaLSP = new System.Windows.Forms.ToolStripButton();
            this.ts_2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_suaLSP = new System.Windows.Forms.ToolStripButton();
            this.ts_3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.ts_4 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_lamMoiDS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.tscbb_loaiThongTin = new System.Windows.Forms.ToolStripComboBox();
            this.tsTxt_nhapThongTin = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_timLSP = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tstxt_maLSP = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tstxt_tenLoai = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LSP)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_LSP
            // 
            this.dgv_LSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LSP.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_LSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coll_maLoai,
            this.coll_tenLoai});
            this.dgv_LSP.Location = new System.Drawing.Point(25, 91);
            this.dgv_LSP.Name = "dgv_LSP";
            this.dgv_LSP.RowHeadersWidth = 51;
            this.dgv_LSP.RowTemplate.Height = 24;
            this.dgv_LSP.Size = new System.Drawing.Size(978, 200);
            this.dgv_LSP.TabIndex = 40;
            this.dgv_LSP.SelectionChanged += new System.EventHandler(this.dgv_LSP_SelectionChanged);
            // 
            // coll_maLoai
            // 
            this.coll_maLoai.HeaderText = "Mã Loại";
            this.coll_maLoai.MinimumWidth = 6;
            this.coll_maLoai.Name = "coll_maLoai";
            // 
            // coll_tenLoai
            // 
            this.coll_tenLoai.HeaderText = "Tên Loại";
            this.coll_tenLoai.MinimumWidth = 6;
            this.coll_tenLoai.Name = "coll_tenLoai";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_themLSP,
            this.ts_1,
            this.tsb_xoaLSP,
            this.ts_2,
            this.tsb_suaLSP,
            this.ts_3,
            this.tsb_xoaPhieuNhap,
            this.ts_4,
            this.ts_lamMoiDS,
            this.toolStripSeparator6,
            this.toolStripTextBox2,
            this.tscbb_loaiThongTin,
            this.tsTxt_nhapThongTin,
            this.tsb_timLSP,
            this.toolStripSeparator5,
            this.tstxt_maLSP,
            this.toolStripSeparator4,
            this.tstxt_tenLoai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1410, 28);
            this.toolStrip1.TabIndex = 41;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_themLSP
            // 
            this.tsb_themLSP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_themLSP.Image = ((System.Drawing.Image)(resources.GetObject("tsb_themLSP.Image")));
            this.tsb_themLSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_themLSP.Name = "tsb_themLSP";
            this.tsb_themLSP.Size = new System.Drawing.Size(29, 25);
            this.tsb_themLSP.Text = "&Thêm Loại Sản Phẩm";
            this.tsb_themLSP.Click += new System.EventHandler(this.tsb_themLSP_Click);
            // 
            // ts_1
            // 
            this.ts_1.Name = "ts_1";
            this.ts_1.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_xoaLSP
            // 
            this.tsb_xoaLSP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_xoaLSP.Image = ((System.Drawing.Image)(resources.GetObject("tsb_xoaLSP.Image")));
            this.tsb_xoaLSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_xoaLSP.Name = "tsb_xoaLSP";
            this.tsb_xoaLSP.Size = new System.Drawing.Size(29, 25);
            this.tsb_xoaLSP.Text = "&Xóa Loại Sản Phẩm";
            this.tsb_xoaLSP.Click += new System.EventHandler(this.tsb_xoaLSP_Click);
            // 
            // ts_2
            // 
            this.ts_2.Name = "ts_2";
            this.ts_2.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_suaLSP
            // 
            this.tsb_suaLSP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_suaLSP.Image = ((System.Drawing.Image)(resources.GetObject("tsb_suaLSP.Image")));
            this.tsb_suaLSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_suaLSP.Name = "tsb_suaLSP";
            this.tsb_suaLSP.Size = new System.Drawing.Size(29, 25);
            this.tsb_suaLSP.Text = "&Sửa Loại Sản Phẩm  ";
            this.tsb_suaLSP.Click += new System.EventHandler(this.tsb_suaLSP_Click);
            // 
            // ts_3
            // 
            this.ts_3.Name = "ts_3";
            this.ts_3.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_xoaPhieuNhap
            // 
            this.tsb_xoaPhieuNhap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_xoaPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("tsb_xoaPhieuNhap.Image")));
            this.tsb_xoaPhieuNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_xoaPhieuNhap.Name = "tsb_xoaPhieuNhap";
            this.tsb_xoaPhieuNhap.Size = new System.Drawing.Size(29, 25);
            this.tsb_xoaPhieuNhap.Text = "&Xóa Phiếu Nhập";
            this.tsb_xoaPhieuNhap.Click += new System.EventHandler(this.tsb_xoaPhieuNhap_Click);
            // 
            // ts_4
            // 
            this.ts_4.Name = "ts_4";
            this.ts_4.Size = new System.Drawing.Size(6, 28);
            // 
            // ts_lamMoiDS
            // 
            this.ts_lamMoiDS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_lamMoiDS.Image = ((System.Drawing.Image)(resources.GetObject("ts_lamMoiDS.Image")));
            this.ts_lamMoiDS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_lamMoiDS.Name = "ts_lamMoiDS";
            this.ts_lamMoiDS.Size = new System.Drawing.Size(29, 25);
            this.ts_lamMoiDS.Text = "&Làm Mới Danh Sách";
            this.ts_lamMoiDS.Click += new System.EventHandler(this.ts_lamMoiDS_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Enabled = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 28);
            this.toolStripTextBox2.Text = "Search";
            // 
            // tscbb_loaiThongTin
            // 
            this.tscbb_loaiThongTin.Name = "tscbb_loaiThongTin";
            this.tscbb_loaiThongTin.Size = new System.Drawing.Size(140, 28);
            this.tscbb_loaiThongTin.Text = "Loại Thông Tin";
            this.tscbb_loaiThongTin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbb_loaiThongTin_KeyPress);
            // 
            // tsTxt_nhapThongTin
            // 
            this.tsTxt_nhapThongTin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTxt_nhapThongTin.Name = "tsTxt_nhapThongTin";
            this.tsTxt_nhapThongTin.Size = new System.Drawing.Size(100, 28);
            this.tsTxt_nhapThongTin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsTxt_nhapThongTin_KeyPress);
            // 
            // tsb_timLSP
            // 
            this.tsb_timLSP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_timLSP.Image = ((System.Drawing.Image)(resources.GetObject("tsb_timLSP.Image")));
            this.tsb_timLSP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_timLSP.Name = "tsb_timLSP";
            this.tsb_timLSP.Size = new System.Drawing.Size(29, 25);
            this.tsb_timLSP.Text = "&Tìm Loại Sản Phẩm";
            this.tsb_timLSP.Click += new System.EventHandler(this.tsb_timLSP_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // tstxt_maLSP
            // 
            this.tstxt_maLSP.Enabled = false;
            this.tstxt_maLSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxt_maLSP.Name = "tstxt_maLSP";
            this.tstxt_maLSP.ReadOnly = true;
            this.tstxt_maLSP.Size = new System.Drawing.Size(150, 28);
            this.tstxt_maLSP.Text = "Mã Loại Sản Phẩm";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // tstxt_tenLoai
            // 
            this.tstxt_tenLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxt_tenLoai.Name = "tstxt_tenLoai";
            this.tstxt_tenLoai.Size = new System.Drawing.Size(100, 28);
            this.tstxt_tenLoai.Enter += new System.EventHandler(this.tstxt_tenLoai_Enter);
            this.tstxt_tenLoai.Leave += new System.EventHandler(this.tstxt_tenLoai_Leave);
            this.tstxt_tenLoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstxt_tenLoai_KeyPress);
            // 
            // LoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 683);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_LSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoaiSanPham";
            this.Text = "LoaiSanPham";
            this.Load += new System.EventHandler(this.LoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LSP)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_LSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_maLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_tenLoai;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_themLSP;
        private System.Windows.Forms.ToolStripSeparator ts_1;
        private System.Windows.Forms.ToolStripButton tsb_xoaLSP;
        private System.Windows.Forms.ToolStripSeparator ts_2;
        private System.Windows.Forms.ToolStripButton tsb_suaLSP;
        private System.Windows.Forms.ToolStripSeparator ts_3;
        private System.Windows.Forms.ToolStripButton tsb_xoaPhieuNhap;
        private System.Windows.Forms.ToolStripSeparator ts_4;
        private System.Windows.Forms.ToolStripButton ts_lamMoiDS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripComboBox tscbb_loaiThongTin;
        private System.Windows.Forms.ToolStripTextBox tsTxt_nhapThongTin;
        private System.Windows.Forms.ToolStripButton tsb_timLSP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox tstxt_tenLoai;
        private System.Windows.Forms.ToolStripTextBox tstxt_maLSP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}