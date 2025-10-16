using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BLL
{
    public class TkDoanhThuBLL
    {
        TkDoanhThuAccess tka = new TkDoanhThuAccess();
        public DataTable LayDoanhThuTheoThangBLL()
        {
            DataTable info = tka.LayDoanhThuTheoThang();
            return info;
        }

        public DataTable LaySanPhamBanChayBLL()
        {
            DataTable info = tka.LaySanPhamBanChay();
            return info;
        }

        public DataTable KhachHangMuaNhieuBLL()
        {
            DataTable info = tka.KhachHangMuaNhieu();
            return info;
        }

        public DataTable doanhSoTheoNgayBLL()
        {
            DataTable info = tka.doanhSoTheoNgay();
            return info;
        }

        public DataTable doanhSoTheoThangBLL()
        {
            DataTable info = tka.doanhSoTheoThang();
            return info;
        }

        public DataTable doanhSoTheoNamBLL()
        {
            DataTable info = tka.doanhSoTheoNam();
            return info;
        }
    }
}
