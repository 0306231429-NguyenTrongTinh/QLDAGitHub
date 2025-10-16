using System;
using System.Windows.Forms;
using QLBH.Charts;

namespace QLBH.Forms
{
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            DoanhThuChart chart = new DoanhThuChart();
            pnlChart.Controls.Add(chart);
            chart.Dock = DockStyle.Fill;
        }
    }
}
