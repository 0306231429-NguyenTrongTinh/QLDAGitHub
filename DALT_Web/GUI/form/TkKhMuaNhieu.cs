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
using DTO;
using BLL;
namespace GUI.form
{
    
    public partial class TkKhMuaNhieu: Form
    {
        TkDoanhThuBLL tkb = new TkDoanhThuBLL();
        public TkKhMuaNhieu()
        {
            InitializeComponent();
        }

        private void TkKhMuaNhieu_Load(object sender, EventArgs e)
        {
            DataTable dt = tkb.KhachHangMuaNhieuBLL();
            dgv_topKH.DataSource = dt;
            dgv_topKH.AllowUserToAddRows = false;

            LoadChartTopKhachHang();
        }

        private void LoadChartTopKhachHang()
        {
            DataTable dt = tkb.KhachHangMuaNhieuBLL(); // Hàm trả DataTable từ truy vấn trên

            chart_khMuaNhieu.Series.Clear();
            chart_khMuaNhieu.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("KhachHangArea");
            chart_khMuaNhieu.ChartAreas.Add(chartArea);

            Series series = new Series("Top khách hàng")
            {
                ChartType = SeriesChartType.Bar
               
            };
            

            foreach (DataRow row in dt.Rows)
            {
                string hoTen = row["HoTen"].ToString();
                double tongChiTieu = Convert.ToDouble(row["TongChiTieu"]);
                series.Points.AddXY(hoTen, tongChiTieu);
            }

            chart_khMuaNhieu.Series.Add(series);
        }

    }
}
