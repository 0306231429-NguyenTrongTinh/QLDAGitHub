namespace GUI.form
{
    partial class ThongKeDoanhThu
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
            this.char_thongKeDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.char_thongKeDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // char_thongKeDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.char_thongKeDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.char_thongKeDoanhThu.Legends.Add(legend1);
            this.char_thongKeDoanhThu.Location = new System.Drawing.Point(12, 12);
            this.char_thongKeDoanhThu.Name = "char_thongKeDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.char_thongKeDoanhThu.Series.Add(series1);
            this.char_thongKeDoanhThu.Size = new System.Drawing.Size(1376, 572);
            this.char_thongKeDoanhThu.TabIndex = 0;
            this.char_thongKeDoanhThu.Text = "chart1";
            this.char_thongKeDoanhThu.Click += new System.EventHandler(this.char_thongKeDoanhThu_Click);
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 683);
            this.Controls.Add(this.char_thongKeDoanhThu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeDoanhThu";
            this.Text = "ThongKeDoanhThu";
            this.Load += new System.EventHandler(this.ThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.char_thongKeDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart char_thongKeDoanhThu;
    }
}