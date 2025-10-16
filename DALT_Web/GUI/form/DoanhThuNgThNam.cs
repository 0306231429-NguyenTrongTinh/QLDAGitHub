using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Windows.Forms.DataVisualization.Charting;
namespace GUI.form
{
    public partial class DoanhThuNgThNam: Form
    {
        TkDoanhThuBLL tkb = new TkDoanhThuBLL();
        public DoanhThuNgThNam()
        {
            InitializeComponent();
        }

        private void DoanhThuNgThNam_Load(object sender, EventArgs e)
        {
            cbb_doanhThu.Items.Add("Ngày");
            cbb_doanhThu.Items.Add("Tháng");
            cbb_doanhThu.Items.Add("Năm");
            cbb_doanhThu.SelectedIndex = 0;
        }

        private void cbb_doanhThu_SelectedIndexChanged(object sender, EventArgs e)
        {

            string loaiThongKe = cbb_doanhThu.SelectedItem.ToString();

            DataTable dt = new DataTable();

            switch (loaiThongKe)
            {
                case "Ngày":
                    dt = tkb.doanhSoTheoNgayBLL();
                    break;
                case "Tháng":
                    dt = tkb.doanhSoTheoThangBLL();
                    break;
                case "Năm":
                    dt = tkb.doanhSoTheoNamBLL();
                    break;
            }

            LoadChartDoanhSo(dt, loaiThongKe);
        }

        private void LoadChartDoanhSo(DataTable dt, string loai)
        {
            chart_doanhThu.Series.Clear();
            chart_doanhThu.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("DoanhSoArea");
            chart_doanhThu.ChartAreas.Add(chartArea);

            Series series = new Series("Doanh số")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            foreach (DataRow row in dt.Rows)
            {
                string label = "";
                double tongTien = Convert.ToDouble(row["TongTien"]);

                switch (loai)
                {
                    case "Ngày":
                        label = Convert.ToDateTime(row["Ngay"]).ToString("dd/MM/yyyy");
                        break;
                    case "Tháng":
                        label = "Tháng " + row["Thang"].ToString();
                        break;
                    case "Năm":
                        label = "Năm " + row["Nam"].ToString();
                        break;
                }

                series.Points.AddXY(label, tongTien);
            }

            chart_doanhThu.Series.Add(series);
        }

        private void chart_doanhThu_Click(object sender, EventArgs e)
        {

        }
    }
}
