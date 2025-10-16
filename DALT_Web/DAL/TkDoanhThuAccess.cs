using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TkDoanhThuAccess
    {

        public DataTable LayDoanhThuTheoThang()
        {
            
            string query = @"
                SELECT FORMAT(HoaDon.NgayLap, 'MM') AS Thang,
                       SUM(ChiTietHoaDon.ThanhTien) AS DoanhThu
                FROM HoaDon
                JOIN ChiTietHoaDon ON HoaDon.MaHoaDon = ChiTietHoaDon.MaHoaDon
                WHERE HoaDon.TrangThai = N'Đã thanh toán'
                GROUP BY FORMAT(HoaDon.NgayLap, 'MM')
                ORDER BY Thang";

            using (SqlConnection conn = SqlConnectionData.connect())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable LaySanPhamBanChay()
        {
            string query = @"
                SELECT SP.MaSanPham, SP.TenSanPham, SUM(CTHD.SoLuong) AS TongSoLuongBan
                FROM ChiTietHoaDon CTHD
                JOIN SanPham SP ON CTHD.MaSanPham = SP.MaSanPham
                JOIN HoaDon HD ON CTHD.MaHoaDon = HD.MaHoaDon
                WHERE HD.TrangThai = N'Đã thanh toán'
                GROUP BY SP.MaSanPham, SP.TenSanPham
                ORDER BY TongSoLuongBan DESC";

            using (SqlConnection conn = SqlConnectionData.connect())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }


        public DataTable KhachHangMuaNhieu()
        {
            string query = @"
                SELECT TOP 10
                KH.MaKhachHang,
                KH.HoTen,
                SUM(HD.TongTien) AS TongChiTieu
                FROM HoaDon HD
                JOIN KhachHang KH ON HD.MaKhachHang = KH.MaKhachHang
                WHERE HD.TrangThai = N'Đã thanh toán'
                GROUP BY KH.MaKhachHang, KH.HoTen
                ORDER BY TongChiTieu DESC;";

            using (SqlConnection conn = SqlConnectionData.connect())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable doanhSoTheoNgay()
        {
            string query = @"
                SELECT CONVERT(date, NgayLap) AS Ngay, SUM(TongTien) AS TongTien
                FROM HoaDon
                WHERE TrangThai = N'Đã thanh toán'
                GROUP BY CONVERT(date, NgayLap)
                ORDER BY Ngay";

            using (SqlConnection conn = SqlConnectionData.connect())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable doanhSoTheoThang()
        {
            string query = @"
                SELECT MONTH(NgayLap) AS Thang, SUM(TongTien) AS TongTien
                FROM HoaDon
                WHERE TrangThai = N'Đã thanh toán'
                GROUP BY MONTH(NgayLap)
                ORDER BY Thang";

            using (SqlConnection conn = SqlConnectionData.connect())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable doanhSoTheoNam()
        {
            string query = @"
                SELECT YEAR(NgayLap) AS Nam, SUM(TongTien) AS TongTien
                FROM HoaDon
                WHERE TrangThai = N'Đã thanh toán'
                GROUP BY YEAR(NgayLap)
                ORDER BY Nam";

            using (SqlConnection conn = SqlConnectionData.connect())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
