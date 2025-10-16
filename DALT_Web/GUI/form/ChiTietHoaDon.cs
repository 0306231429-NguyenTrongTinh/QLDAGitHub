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
using DTO;
using BLL;

namespace GUI.form
{
    public partial class ChiTietHoaDon: Form
    {
        private string mahd;
        public ChiTietHoaDon(string value)
        {
            InitializeComponent();
            mahd = value;
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {

            ChiTietHoaDonBLL cthdb = new ChiTietHoaDonBLL();
            List<ChiTietHoaDonDTO> dsSV = cthdb.loadCthdBLL(mahd);
            this.rp_cthd.LocalReport.ReportEmbeddedResource =
            "GUI.form.ChiTietHoaDon.rdlc";
            this.rp_cthd.LocalReport.DataSources.Add(new
            ReportDataSource("CTHD", dsSV));
            this.rp_cthd.RefreshReport();


            
        }
    }
}
