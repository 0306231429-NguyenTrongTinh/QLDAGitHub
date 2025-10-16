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
    public class HoaDonAccess 
    {

        public List<HoaDonDTO> loadDsHoaDonDAL()  // Load danh sách HD
        {
            List<HoaDonDTO> dsHD = new List<HoaDonDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT * FROM HoaDon";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    HoaDonDTO hd = new HoaDonDTO();

                    hd.MaHoaDon = da["MaHoaDon"].ToString();
                    hd.NgayLap = DateTime.Parse(da["NgayLap"].ToString());
                    hd.MaNhanVien = da["MaNhanVien"].ToString();
                    hd.MaKhachHang = da["MaKhachHang"].ToString();
                    hd.TongTien = float.Parse(da["TongTien"].ToString());
                    hd.HinhThuc = da["HinhThuc"].ToString();
                    hd.TrangThai = da["TrangThai"].ToString();

                    dsHD.Add(hd);
                }
                da.Close();
                conn.Close();

            }
            return dsHD;
        }
        public List<HoaDonDTO> LoadSearchHdDAL(string tt, string value)  // Tìm thông tin HD
        {
            List<HoaDonDTO> sear = new List<HoaDonDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            SqlCommand cm = null;
            string query = "";


            switch (tt.ToLower())
            {
                case "mahd":
                    query = "SELECT * FROM HoaDon WHERE MaHoaDon LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "manv":
                    query = "SELECT * FROM HoaDon WHERE MaNhanVien LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "makh":
                    query = "SELECT * FROM HoaDon WHERE MaKhachHang LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "tt":
                    query = "SELECT * FROM HoaDon WHERE TrangThai LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                default:
                    throw new ArgumentException("Tham số tìm kiếm không hợp lệ.");
            }


            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    HoaDonDTO hd = new HoaDonDTO();

                    hd.MaHoaDon = da["MaHoaDon"].ToString();
                    hd.NgayLap = DateTime.Parse(da["NgayLap"].ToString());
                    hd.MaNhanVien = da["MaNhanVien"].ToString();
                    hd.MaKhachHang = da["MaKhachHang"].ToString();
                    hd.TongTien = float.Parse(da["TongTien"].ToString());
                    hd.HinhThuc = da["HinhThuc"].ToString();
                    hd.TrangThai = da["TrangThai"].ToString();
                    sear.Add(hd);
                }
                da.Close();
                conn.Close();
            }
            else
            {
                conn.Close();
            }

            return sear;
        }
        public string GenerateMaHoaDonDAL() // Tạo mã HD tự động
        {
            string maHD = "HD001"; // mặc định nếu chưa có hóa đơn nào
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT TOP 1 MaHoaDon FROM HoaDon ORDER BY MaHoaDon DESC";
            SqlCommand cmd = new SqlCommand(query, conn);

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                string lastMaHD = result.ToString(); // ví dụ: HD009
                int number = int.Parse(lastMaHD.Substring(2)); // cắt lấy phần số: 009 => 9
                number++;
                maHD = "HD" + number.ToString("D3"); // format lại thành HD010, HD011...
            }

            conn.Close();
            return maHD;
        }
        public string themhdDAL(HoaDonDTO hd)   // Thêm hóa đơn
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "INSERT INTO HoaDon VALUES (@maHD, @ngayLap, @maNV,@maKH,@tongTien,@hinhThuc,@trangThai)";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@maHD", hd.MaHoaDon);
            cm.Parameters.AddWithValue("@ngayLap", hd.NgayLap);
            cm.Parameters.AddWithValue("@maNV", hd.MaNhanVien);
            cm.Parameters.AddWithValue("@maKH", hd.MaKhachHang);
            cm.Parameters.AddWithValue("@tongTien", hd.TongTien);
            cm.Parameters.AddWithValue("@hinhThuc", hd.HinhThuc);
            cm.Parameters.AddWithValue("@trangThai", hd.TrangThai);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            int rowsAffected = cm.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                kq = "ttc";
            }
            else
            {
                return "ttb";
            }
            return kq;

        }
        public string xoaHdDAL(string mhd) // Xóa HD
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "DELETE FROM HoaDon WHERE MaHoaDon = @maHD";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@maHD", mhd);

            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            int rowsAffected = cm.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                kq = "xtc";
            }
            else
            {
                return "xtb";
            }
            return kq;
        }

        public string updateHdDAL(HoaDonDTO hd)  // Chỉnh sửa HD
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE HoaDon SET NgayLap = @dt,MaNhanVien = @manv," +
                "MaKhachHang = @makh,TongTien = @tongt,HinhThuc=@hinhT, TrangThai=@TrangThai WHERE MaHoaDon = @mHd";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.Parameters.AddWithValue("@dt", hd.NgayLap);
            cm.Parameters.AddWithValue("@manv", hd.MaNhanVien);
            cm.Parameters.AddWithValue("@makh", hd.MaKhachHang);
            cm.Parameters.AddWithValue("@tongt", hd.TongTien);
            cm.Parameters.AddWithValue("@hinhT", hd.HinhThuc);
            cm.Parameters.AddWithValue("@TrangThai", hd.TrangThai);
            cm.Parameters.AddWithValue("@mHd", hd.MaHoaDon);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            int rowsAffected = cm.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                kq = "stc";
            }
            else
            {
                return "stb";
            }
            return kq;
        }

        public List<string> LoadMaHdDAL()  // Load MaHD lên cbb
        {
            List<string> dsSHoaDon = new List<string>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            SqlCommand cm = new SqlCommand("SELECT MaHoaDon from HoaDon where TrangThai=N'Chưa thanh toán' ", conn);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;
            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    dsSHoaDon.Add(da["MaHoaDon"].ToString());
                }
                da.Close();
                conn.Close();

            }
            return dsSHoaDon;
        }

        public string tongTienHdDAL(string mhd) // load tong tien hoa don
        {
            string kq="0" ;
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                string query = "select sum(ThanhTien) as TongTien from ChiTietHoaDon where MaHoaDon=@mhd";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mhd", mhd);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) // Có dòng => hoa don đã tồn tại
                {
                    while (reader.Read())
                    {
                        kq = reader["TongTien"].ToString();
                    }
                }
                reader.Close();
            }
            return kq;
        }


    }
}
