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
    public class ChiTietHoaDonAccess 
    {
        public List<ChiTietHoaDonDTO> loadCthdDAL(string value)  // Load cthd tu MaHD 
        {
            List<ChiTietHoaDonDTO> dsCthd = new List<ChiTietHoaDonDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT * FROM ChiTietHoaDon where MaHoaDon=@mhd";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@mhd", value);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO();

                    cthd.MaHoaDon = da["MaHoaDon"].ToString();
                    cthd.MaSanPham = da["MaSanPham"].ToString();
                    cthd.DonGia = float.Parse(da["DonGia"].ToString());
                    cthd.SoLuong = int.Parse(da["SoLuong"].ToString());
                    cthd.ThanhTien = float.Parse(da["ThanhTien"].ToString());


                    dsCthd.Add(cthd);
                }
                da.Close();
                conn.Close();

            }
            return dsCthd;
        }

        public string themCthdDAL(ChiTietHoaDonDTO cthd)  // Thêm cthd
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "INSERT INTO ChiTietHoaDon VALUES (@MaHoaDon, @MaSanPham, @SoLuong,@DonGia)";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaHoaDon", cthd.MaHoaDon);
            cm.Parameters.AddWithValue("@MaSanPham", cthd.MaSanPham);
            cm.Parameters.AddWithValue("@SoLuong", cthd.SoLuong);
            cm.Parameters.AddWithValue("@DonGia", cthd.DonGia);
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

        public string xoaRowCthdDAL(string maHD, string maSP) // xoa mot dong cthd
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "DELETE FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon AND MaSanPham = @MaSanPham";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaHoaDon", maHD);
            cm.Parameters.AddWithValue("@MaSanPham", maSP);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            int rowsAffected = cm.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                kq = "xtc"; // xóa thành công
            }
            else
            {
                kq = "xtb"; // xóa thất bại
            }

            conn.Close();
            return kq;
        }

        public string xoaCthdDAL(string mhd) // Xóa cthd
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "DELETE FROM ChiTietHoaDon WHERE MaHoaDon = @maHD";
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

        public string updCthd_HD_DAL(string mhd)  // load tổng tiền cthd lên hóa đơn
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = @"
            UPDATE HoaDon
            SET TongTien = (
                SELECT ISNULL(SUM(SoLuong * DonGia), 0)
                FROM ChiTietHoaDon
                WHERE MaHoaDon = @maHD
            )
            WHERE MaHoaDon = @maHD"; ;
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@maHD", mhd);

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

        public string updateCthdDAL(ChiTietHoaDonDTO cthd) // Chỉnh sửa cthd
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE ChiTietHoaDon SET SoLuong = @SoLuong,DonGia = @DonGia WHERE MaSanPham = @msp";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.Parameters.AddWithValue("@SoLuong", cthd.SoLuong);
            cm.Parameters.AddWithValue("@DonGia", cthd.DonGia);
            cm.Parameters.AddWithValue("@msp", cthd.MaSanPham);
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

        public string kiemTraSpCthdDAL(string mhd, string msp) // Kiểm tra sản phẩm đã tồn tại trong cthd chưa
        {
            string kq = "ktt";
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                string query = "SELECT * FROM ChiTietHoaDon WHERE MaHoaDon=@mhd and MaSanPham=@msp";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mhd", mhd);
                cmd.Parameters.AddWithValue("@msp", msp);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) // Có dòng => sản phẩm đã tồn tại
                {
                    kq = "tt";
                }
                reader.Close();
            }
            return kq;
        }

        public string maKH_maHdDAL(string mhd)  // Load MaKH tương ứng khi chọn MaHD
        {
            string kq = "";
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                string query = "SELECT MaKhachHang FROM HoaDon WHERE MaHoaDon=@mhd ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mhd", mhd);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        kq = reader["MaKhachHang"].ToString();
                    }
                    reader.Close();
                    conn.Close();
                }
            }
            return kq;
        }

        public float kiemTraThanhTienCthdDAL(string mhd, string msp) // Kiểm tra thanh tien đã tồn tại trong cthd
        {
            float tt = -1; // Mặc định là -1 nếu không tìm thấy
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                string query = "SELECT ThanhTien FROM ChiTietHoaDon WHERE MaHoaDon=@mhd AND MaSanPham=@msp";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mhd", mhd);
                cmd.Parameters.AddWithValue("@msp", msp);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read()) // Đọc dòng đầu tiên (vì chỉ có 1 dòng)
                    {
                        tt = float.Parse(reader["ThanhTien"].ToString());
                    }
                }

                reader.Close();
                conn.Close();
            }

            return tt;
        }

        public int LoadSlCthdDAL(string mhd, string msp) // Load so luong cthd
        {
            int sl = 0;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "SELECT SoLuong from ChiTietHoaDon where MaHoaDon=@mhd and MaSanPham=@msp";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@mhd", mhd);
            cmd.Parameters.AddWithValue("@msp", msp);
            cmd.Connection = conn;
            SqlDataReader da = cmd.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    sl=(int)(da["SoLuong"]);
                }
                da.Close();
                conn.Close();

            }
            return sl;
        }
    }
}
