using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLBH.Charts
{
    public class DoanhThuChart : UserControl
    {
        public DoanhThuChart()
        {
            Chart chart = new Chart();
            ChartArea area = new ChartArea();
            chart.ChartAreas.Add(area);

            Series series = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Column
            };

            series.Points.AddXY("Tháng 1", 2000000);
            series.Points.AddXY("Tháng 2", 3500000);
            series.Points.AddXY("Tháng 3", 5000000);

            chart.Series.Add(series);
            chart.Dock = DockStyle.Fill;

            Controls.Add(chart);
        }
    }
}
