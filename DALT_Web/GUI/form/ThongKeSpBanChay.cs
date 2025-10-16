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
    public partial class ThongKeSpBanChay: Form
    {
        TkDoanhThuBLL tkb = new TkDoanhThuBLL();
        public ThongKeSpBanChay()
        {
            InitializeComponent();
        }

        private void ThongKeSpBanChay_Load(object sender, EventArgs e)
        {

            
            DataTable dt = tkb.LaySanPhamBanChayBLL();
            dgv_sanPhamBanChay.DataSource = dt;
            dgv_sanPhamBanChay.AllowUserToAddRows = false;
            LoadChartSanPhamBanChay();
        }

        private void LoadChartSanPhamBanChay()
        {
            
            DataTable dt = tkb.LaySanPhamBanChayBLL();

            chart_spBanChay.Series.Clear();
            chart_spBanChay.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("SanPhamArea");
            chart_spBanChay.ChartAreas.Add(chartArea);

            Series series = new Series("Sản phẩm bán chạy")
            {
                ChartType = SeriesChartType.Pie
            };

            series.Label = "#PERCENT";
            series.LegendText = "#VALX";

            foreach (DataRow row in dt.Rows)
            {
                string tenSP = row["TenSanPham"].ToString();
                int soLuong = Convert.ToInt32(row["TongSoLuongBan"]);
                series.Points.AddXY(tenSP, soLuong);
            }

            chart_spBanChay.Series.Add(series);
        }

    }
}
