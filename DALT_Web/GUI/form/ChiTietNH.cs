using BLL;
using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.form
{
    public partial class ChiTietNH: Form
    {
        private string mapn = "";
        public ChiTietNH(string mpn)
        {
            InitializeComponent();
            mapn = mpn;
        }

        private void ChiTietNH_Load(object sender, EventArgs e)
        {
            ChiTietNhapHangBLL ctnhb = new ChiTietNhapHangBLL();
            List<ChiTietNhapHangDTO> dsnh = ctnhb.loadCthdBLL(mapn);
            this.report_NhapHang.LocalReport.ReportEmbeddedResource =
            "GUI.form.ChiTietNH.rdlc";
            this.report_NhapHang.LocalReport.DataSources.Add(new
            ReportDataSource("DsNhapHang", dsnh));


            this.report_NhapHang.RefreshReport();
        }
    }
}
