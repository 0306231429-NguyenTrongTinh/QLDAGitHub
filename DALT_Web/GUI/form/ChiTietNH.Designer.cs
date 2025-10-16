namespace GUI.form
{
    partial class ChiTietNH
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
            this.report_NhapHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // report_NhapHang
            // 
            this.report_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report_NhapHang.Location = new System.Drawing.Point(0, 0);
            this.report_NhapHang.Name = "report_NhapHang";
            this.report_NhapHang.ServerReport.BearerToken = null;
            this.report_NhapHang.Size = new System.Drawing.Size(800, 450);
            this.report_NhapHang.TabIndex = 0;
            // 
            // ChiTietNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.report_NhapHang);
            this.Name = "ChiTietNH";
            this.Text = "ChiTietNH";
            this.Load += new System.EventHandler(this.ChiTietNH_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer report_NhapHang;
    }
}