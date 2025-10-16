namespace GUI.form
{
    partial class NhaCungCap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaCungCap));
            this.dgv_NCC = new System.Windows.Forms.DataGridView();
            this.coll_maNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coll_diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tienGuiTra = new System.Windows.Forms.TextBox();
            this.txt_tenNCC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_themNCC = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaNCC = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_suaCCC = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_xoaPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_lamMoiDS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.tscbb_loaiThongTin = new System.Windows.Forms.ToolStripComboBox();
            this.tsTxt_nhapThongTin = new System.Windows.Forms.ToolStripTextBox();
            this.tsb_timNCC = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tstxt_maNCC = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_NCC
            // 
            this.dgv_NCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NCC.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coll_maNCC,
            this.coll_tenNCC,
            this.coll_sdt,
            this.coll_diaChi});
            this.dgv_NCC.Location = new System.Drawing.Point(13, 116);
            this.dgv_NCC.Name = "dgv_NCC";
            this.dgv_NCC.RowHeadersWidth = 51;
            this.dgv_NCC.RowTemplate.Height = 24;
            this.dgv_NCC.Size = new System.Drawing.Size(1340, 200);
            this.dgv_NCC.TabIndex = 38;
            this.dgv_NCC.SelectionChanged += new System.EventHandler(this.dgv_NCC_SelectionChanged);
            // 
            // coll_maNCC
            // 
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.coll_maNCC.DefaultCellStyle = dataGridViewCellStyle29;
            this.coll_maNCC.HeaderText = "Mã Nhà Cung cấp";
            this.coll_maNCC.MinimumWidth = 6;
            this.coll_maNCC.Name = "coll_maNCC";
            // 
            // coll_tenNCC
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.coll_tenNCC.DefaultCellStyle = dataGridViewCellStyle30;
            this.coll_tenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.coll_tenNCC.MinimumWidth = 6;
            this.coll_tenNCC.Name = "coll_tenNCC";
            // 
            // coll_sdt
            // 
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.coll_sdt.DefaultCellStyle = dataGridViewCellStyle31;
            this.coll_sdt.HeaderText = "Số Điện Thoại";
            this.coll_sdt.MinimumWidth = 6;
            this.coll_sdt.Name = "coll_sdt";
            // 
            // coll_diaChi
            // 
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.coll_diaChi.DefaultCellStyle = dataGridViewCellStyle32;
            this.coll_diaChi.HeaderText = "Địa Chỉ";
            this.coll_diaChi.MinimumWidth = 6;
            this.coll_diaChi.Name = "coll_diaChi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_diaChi);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txt_sdt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_tienGuiTra);
            this.panel2.Controls.Add(this.txt_tenNCC);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(13, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1340, 62);
            this.panel2.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(899, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Địa Chỉ:";
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diaChi.Location = new System.Drawing.Point(1045, 12);
            this.txt_diaChi.Multiline = true;
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(216, 27);
            this.txt_diaChi.TabIndex = 19;
            this.txt_diaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_diaChi_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(435, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 19);
            this.label15.TabIndex = 18;
            this.label15.Text = "Số Điện Thoại:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(627, 12);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(216, 27);
            this.txt_sdt.TabIndex = 16;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(825, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tiền gửi trả";
            // 
            // txt_tienGuiTra
            // 
            this.txt_tienGuiTra.Location = new System.Drawing.Point(942, 243);
            this.txt_tienGuiTra.Name = "txt_tienGuiTra";
            this.txt_tienGuiTra.Size = new System.Drawing.Size(100, 22);
            this.txt_tienGuiTra.TabIndex = 10;
            // 
            // txt_tenNCC
            // 
            this.txt_tenNCC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenNCC.Location = new System.Drawing.Point(185, 12);
            this.txt_tenNCC.Multiline = true;
            this.txt_tenNCC.Name = "txt_tenNCC";
            this.txt_tenNCC.Size = new System.Drawing.Size(216, 27);
            this.txt_tenNCC.TabIndex = 10;
            this.txt_tenNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tenNCC_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Tên Nhà Cung Cấp ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_themNCC,
            this.toolStripSeparator,
            this.tsb_xoaNCC,
            this.toolStripSeparator2,
            this.tsb_suaCCC,
            this.toolStripSeparator3,
            this.tsb_xoaPhieuNhap,
            this.toolStripSeparator1,
            this.ts_lamMoiDS,
            this.toolStripSeparator6,
            this.toolStripTextBox2,
            this.tscbb_loaiThongTin,
            this.tsTxt_nhapThongTin,
            this.tsb_timNCC,
            this.toolStripSeparator4,
            this.tstxt_maNCC});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1392, 28);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_themNCC
            // 
            this.tsb_themNCC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_themNCC.Image = ((System.Drawing.Image)(resources.GetObject("tsb_themNCC.Image")));
            this.tsb_themNCC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_themNCC.Name = "tsb_themNCC";
            this.tsb_themNCC.Size = new System.Drawing.Size(29, 25);
            this.tsb_themNCC.Text = "&Thêm Nhà Cung Cấp";
            this.tsb_themNCC.Click += new System.EventHandler(this.tsb_themNCC_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_xoaNCC
            // 
            this.tsb_xoaNCC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_xoaNCC.Image = ((System.Drawing.Image)(resources.GetObject("tsb_xoaNCC.Image")));
            this.tsb_xoaNCC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_xoaNCC.Name = "tsb_xoaNCC";
            this.tsb_xoaNCC.Size = new System.Drawing.Size(29, 25);
            this.tsb_xoaNCC.Text = "&Xóa Nhà Cung Cấp";
            this.tsb_xoaNCC.Click += new System.EventHandler(this.tsb_xoaNCC_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // tsb_suaCCC
            // 
            this.tsb_suaCCC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_suaCCC.Image = ((System.Drawing.Image)(resources.GetObject("tsb_suaCCC.Image")));
            this.tsb_suaCCC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_suaCCC.Name = "tsb_suaCCC";
            this.tsb_suaCCC.Size = new System.Drawing.Size(29, 25);
            this.tsb_suaCCC.Text = "&Sửa Nhà Cung Cấp";
            this.tsb_suaCCC.Click += new System.EventHandler(this.tsb_suaCCC_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
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
            // tsb_timNCC
            // 
            this.tsb_timNCC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_timNCC.Image = ((System.Drawing.Image)(resources.GetObject("tsb_timNCC.Image")));
            this.tsb_timNCC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_timNCC.Name = "tsb_timNCC";
            this.tsb_timNCC.Size = new System.Drawing.Size(29, 25);
            this.tsb_timNCC.Text = "&Tìm Nhà Cung Cấp";
            this.tsb_timNCC.Click += new System.EventHandler(this.tsb_timNCC_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // tstxt_maNCC
            // 
            this.tstxt_maNCC.Enabled = false;
            this.tstxt_maNCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxt_maNCC.Name = "tstxt_maNCC";
            this.tstxt_maNCC.ReadOnly = true;
            this.tstxt_maNCC.Size = new System.Drawing.Size(150, 28);
            this.tstxt_maNCC.Text = "Mã Nhà Cung Cấp ";
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 636);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_NCC);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhaCungCap";
            this.Text = "NhaCungCap";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_NCC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tienGuiTra;
        private System.Windows.Forms.TextBox txt_tenNCC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_themNCC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsb_xoaNCC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_suaCCC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_xoaPhieuNhap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ts_lamMoiDS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripComboBox tscbb_loaiThongTin;
        private System.Windows.Forms.ToolStripTextBox tsTxt_nhapThongTin;
        private System.Windows.Forms.ToolStripButton tsb_timNCC;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox tstxt_maNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_maNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_tenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn coll_diaChi;
    }
}