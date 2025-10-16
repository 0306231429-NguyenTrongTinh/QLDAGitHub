namespace GUI.form
{
    partial class DoanhThuNgThNam
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_doanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbb_doanhThu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_doanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_doanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_doanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_doanhThu.Legends.Add(legend1);
            this.chart_doanhThu.Location = new System.Drawing.Point(12, 35);
            this.chart_doanhThu.Name = "chart_doanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_doanhThu.Series.Add(series1);
            this.chart_doanhThu.Size = new System.Drawing.Size(1368, 558);
            this.chart_doanhThu.TabIndex = 0;
            this.chart_doanhThu.Text = "chart1";
            this.chart_doanhThu.Click += new System.EventHandler(this.chart_doanhThu_Click);
            // 
            // cbb_doanhThu
            // 
            this.cbb_doanhThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_doanhThu.FormattingEnabled = true;
            this.cbb_doanhThu.Location = new System.Drawing.Point(589, 12);
            this.cbb_doanhThu.Name = "cbb_doanhThu";
            this.cbb_doanhThu.Size = new System.Drawing.Size(175, 24);
            this.cbb_doanhThu.TabIndex = 1;
            this.cbb_doanhThu.SelectedIndexChanged += new System.EventHandler(this.cbb_doanhThu_SelectedIndexChanged);
            // 
            // DoanhThuNgThNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 683);
            this.Controls.Add(this.cbb_doanhThu);
            this.Controls.Add(this.chart_doanhThu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoanhThuNgThNam";
            this.Text = "DoanhThuNgThNam";
            this.Load += new System.EventHandler(this.DoanhThuNgThNam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_doanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_doanhThu;
        private System.Windows.Forms.ComboBox cbb_doanhThu;
    }
}