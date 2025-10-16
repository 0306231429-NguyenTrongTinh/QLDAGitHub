namespace GUI.form
{
    partial class ThongKeSpBanChay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_spBanChay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_sanPhamBanChay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart_spBanChay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanPhamBanChay)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_spBanChay
            // 
            chartArea7.Name = "ChartArea1";
            this.chart_spBanChay.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart_spBanChay.Legends.Add(legend7);
            this.chart_spBanChay.Location = new System.Drawing.Point(12, 12);
            this.chart_spBanChay.Name = "chart_spBanChay";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart_spBanChay.Series.Add(series7);
            this.chart_spBanChay.Size = new System.Drawing.Size(875, 605);
            this.chart_spBanChay.TabIndex = 0;
            this.chart_spBanChay.Text = "chart1";
            // 
            // dgv_sanPhamBanChay
            // 
            this.dgv_sanPhamBanChay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sanPhamBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanPhamBanChay.Location = new System.Drawing.Point(893, 12);
            this.dgv_sanPhamBanChay.Name = "dgv_sanPhamBanChay";
            this.dgv_sanPhamBanChay.RowHeadersWidth = 51;
            this.dgv_sanPhamBanChay.RowTemplate.Height = 24;
            this.dgv_sanPhamBanChay.Size = new System.Drawing.Size(493, 331);
            this.dgv_sanPhamBanChay.TabIndex = 1;
            // 
            // ThongKeSpBanChay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 683);
            this.Controls.Add(this.dgv_sanPhamBanChay);
            this.Controls.Add(this.chart_spBanChay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeSpBanChay";
            this.Text = "ThongKeSpBanChay";
            this.Load += new System.EventHandler(this.ThongKeSpBanChay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_spBanChay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanPhamBanChay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_spBanChay;
        private System.Windows.Forms.DataGridView dgv_sanPhamBanChay;
    }
}