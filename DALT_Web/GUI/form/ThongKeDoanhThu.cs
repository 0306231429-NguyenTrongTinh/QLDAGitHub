using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.form
{
    public partial class ThongKeDoanhThu: Form
    {
        TkDoanhThuBLL tkb = new TkDoanhThuBLL();
        public ThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            char_thongKeDoanhThu.Series.Clear();
            char_thongKeDoanhThu.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("ChartArea1");
            char_thongKeDoanhThu.ChartAreas.Add(chartArea);

            Series series = new Series("DoanhThu")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32,
                IsValueShownAsLabel = true
            };
            char_thongKeDoanhThu.ChartAreas[0].AxisX.Title = "Tháng";
            char_thongKeDoanhThu.ChartAreas[0].AxisY.Title = "Doanh Thu (VND)";

            DataTable dt = tkb.LayDoanhThuTheoThangBLL();

            foreach (DataRow row in dt.Rows)
            {
                string thang = "Tháng " + row["Thang"].ToString();
                int doanhThu = Convert.ToInt32(row["DoanhThu"]);
                series.Points.AddXY(thang, doanhThu);
            }

            char_thongKeDoanhThu.Series.Add(series);
        }

        private void char_thongKeDoanhThu_Click(object sender, EventArgs e)
        {

        }
    }
}
