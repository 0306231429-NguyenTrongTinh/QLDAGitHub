namespace GUI.form
{
    partial class TkKhMuaNhieu
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
            this.chart_khMuaNhieu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_topKH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart_khMuaNhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_topKH)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_khMuaNhieu
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_khMuaNhieu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_khMuaNhieu.Legends.Add(legend1);
            this.chart_khMuaNhieu.Location = new System.Drawing.Point(12, 1);
            this.chart_khMuaNhieu.Name = "chart_khMuaNhieu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_khMuaNhieu.Series.Add(series1);
            this.chart_khMuaNhieu.Size = new System.Drawing.Size(1386, 447);
            this.chart_khMuaNhieu.TabIndex = 0;
            this.chart_khMuaNhieu.Text = "chart1";
            // 
            // dgv_topKH
            // 
            this.dgv_topKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_topKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_topKH.Location = new System.Drawing.Point(12, 454);
            this.dgv_topKH.Name = "dgv_topKH";
            this.dgv_topKH.RowHeadersWidth = 51;
            this.dgv_topKH.RowTemplate.Height = 24;
            this.dgv_topKH.Size = new System.Drawing.Size(1386, 174);
            this.dgv_topKH.TabIndex = 1;
            // 
            // TkKhMuaNhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 683);
            this.Controls.Add(this.dgv_topKH);
            this.Controls.Add(this.chart_khMuaNhieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TkKhMuaNhieu";
            this.Text = "TkKhMuaNhieu";
            this.Load += new System.EventHandler(this.TkKhMuaNhieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_khMuaNhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_topKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_khMuaNhieu;
        private System.Windows.Forms.DataGridView dgv_topKH;
    }
}