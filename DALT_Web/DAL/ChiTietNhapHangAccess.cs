using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ChiTietNhapHangAccess
    {

        public string kiemTraSpCthdDAL(string mpn, string msp) // Kiểm tra sản phẩm đã tồn tại trong ctnh chưa
        {
            string kq = "ktt";
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                string query = "SELECT * FROM ChiTietNhapHang WHERE MaPhieuNhap=@mpn and MaSanPham=@msp";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mpn", mpn);
                cmd.Parameters.AddWithValue("@msp", msp);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) 
                {
                    kq = "tt";
                }
                reader.Close();
            }
            return kq;
        }

        public string kiemTraTTspCthdDAL(string mpn) // Kiểm tra co sản phẩm đã tồn tại trong ctnh chưa
        {
            string kq = "ktt";
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                string query = "SELECT * FROM ChiTietNhapHang WHERE MaPhieuNhap=@mpn ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mpn", mpn);
                

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    kq = "tt";
                }
                else
                {
                    kq = "ktt";
                }
                reader.Close();
            }
            return kq;
        }

        public float kiemTraThanhTienCtnhDAL(string mpn, string msp) // Kiểm tra thanh tien đã tồn tại trong ctnh
        {
            float tt = -1; // Mặc định là -1 nếu không tìm thấy
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                string query = "SELECT ThanhTien FROM ChiTietNhapHang WHERE MaPhieuNhap=@mpn AND MaSanPham=@msp";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mpn", mpn);
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

        public string updCtnh_NH_DAL(string mpn)  // load tổng tiền ctnh lên phieu nhap
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = @"
            UPDATE NhapHang
            SET TongTien = (
                SELECT ISNULL(SUM(SoLuong * GiaNhap), 0)
                FROM ChiTietNhapHang
                WHERE MaPhieuNhap = @maPN
            )
            WHERE MaPhieuNhap = @maPN"; ;
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@maPN", mpn);

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

        public string updateCtnhDAL(ChiTietNhapHangDTO ctnh) // Chỉnh sửa ctnh
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE ChiTietNhapHang SET SoLuong = @SoLuong,GiaNhap = @GiaNhap WHERE MaSanPham = @msp";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.Parameters.AddWithValue("@SoLuong", ctnh.SoLuong);
            cm.Parameters.AddWithValue("@GiaNhap", ctnh.GiaNhap);
            cm.Parameters.AddWithValue("@msp", ctnh.MaSanPham);
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

        public string themCtnhDAL(ChiTietNhapHangDTO ctnh)  // Thêm ctnh
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "INSERT INTO ChiTietNhapHang VALUES (@MaSanPham, @MaPhieuNhap, @SoLuong,@GiaNhap)";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaPhieuNhap", ctnh.MaPhieuNhap);
            cm.Parameters.AddWithValue("@MaSanPham", ctnh.MaSanPham);
            cm.Parameters.AddWithValue("@SoLuong", ctnh.SoLuong);
            cm.Parameters.AddWithValue("@GiaNhap", ctnh.GiaNhap);
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

        public List<ChiTietNhapHangDTO> loadCthdDAL(string value)  // Load ctnh tu MaPN
        {
            List<ChiTietNhapHangDTO> dsCtnh = new List<ChiTietNhapHangDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT * FROM ChiTietNhapHang where MaPhieuNhap=@mpn";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@mpn", value);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    ChiTietNhapHangDTO ctnh = new ChiTietNhapHangDTO();

                    ctnh.MaPhieuNhap = da["MaPhieuNhap"].ToString();
                    ctnh.MaSanPham = da["MaSanPham"].ToString();
                    ctnh.GiaNhap = float.Parse(da["GiaNhap"].ToString());
                    ctnh.SoLuong = int.Parse(da["SoLuong"].ToString());
                    ctnh.ThanhTien = float.Parse(da["ThanhTien"].ToString());


                    dsCtnh.Add(ctnh);
                }
                da.Close();
                conn.Close();

            }
            return dsCtnh;
        }

        public string xoaCtnhDAL(string mnh) // Xóa ctnh
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "DELETE FROM ChiTietNhapHang WHERE MaPhieuNhap = @maPN";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@maPN", mnh);

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

        public string xoaRowCtnhDAL(string mapn, string maSP) // xoa mot dong ctnh
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "DELETE FROM ChiTietNhapHang WHERE MaPhieuNhap = @MaPhieuNhap AND MaSanPham = @MaSanPham";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaPhieuNhap", mapn);
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

        public List<string> LoadMaNcc_MaSpDAL(string mancc) // Load mã sản phẩm theo ma ncc lên combobox 
        {
            List<string> dsSanPham = new List<string>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            SqlCommand cm = new SqlCommand("SELECT MaSanPham from SanPham where MaNCC=@MaNCC", conn);
            cm.Parameters.AddWithValue("@MaNCC", mancc);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;
            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    dsSanPham.Add(da["MaSanPham"].ToString());
                }
                da.Close();
                conn.Close();

            }
            return dsSanPham;
        }

        public string LoadMaPn_MaNccDAL(string mpn) // Load mã ncc theo ma pn lên combobox 
        {
            string maNCC = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            SqlCommand cm = new SqlCommand("SELECT MaNhaCungCap from NhapHang where MaPhieuNhap=@MaPhieuNhap", conn);
            cm.Parameters.AddWithValue("@MaPhieuNhap", mpn);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;
            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    maNCC= da["MaNhaCungCap"].ToString();
                }
                da.Close();
                conn.Close();

            }
            return maNCC;
        }


        public List<KhoHangDTO> loadKhoHangTheoMaSP_DAL(string maSanPham) // thong tin cua tung san pham vua nhap
        {
            List<KhoHangDTO> dsKhoH = new List<KhoHangDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT SanPham.MaSanPham, SanPham.SoLuongTon, ChiTietNhapHang.SoLuong, ChiTietNhapHang.GiaNhap, " +
                           "SanPham.DonGia, NhapHang.NgayNhap " +
                           "FROM SanPham " +
                           "JOIN ChiTietNhapHang ON SanPham.MaSanPham = ChiTietNhapHang.MaSanPham " +
                           "JOIN NhapHang ON NhapHang.MaPhieuNhap = ChiTietNhapHang.MaPhieuNhap " +
                           "WHERE SanPham.MaSanPham = @msp";

            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@msp", maSanPham);

            SqlDataReader da = cm.ExecuteReader();
            while (da.Read())
            {
                KhoHangDTO khoh = new KhoHangDTO();

                khoh.MaSanPham = da["MaSanPham"].ToString();
                khoh.SoLuongTon = int.Parse(da["SoLuongTon"].ToString());
                khoh.SoLuongNhap = int.Parse(da["SoLuong"].ToString());
                khoh.GiaNhap = float.Parse(da["GiaNhap"].ToString());
                khoh.GiaBan = float.Parse(da["DonGia"].ToString());
                khoh.NgayCapNhat = DateTime.Parse(da["NgayNhap"].ToString());

                dsKhoH.Add(khoh);
            }

            da.Close();
            conn.Close();

            return dsKhoH;
        }


        public string xoaCtnh_maspDAL(string msp) // Xóa ctnh tu sanpham
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "DELETE FROM ChiTietNhapHang WHERE MaSanPham = @MaSanPham";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaSanPham", msp);

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

        public string updCtnh_xntt_DAL(string mpn)  // load trang thai thanh toan lên phieu nhap
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = @"
            UPDATE NhapHang
            SET TrangThai = N'Đã nhập'
            WHERE MaPhieuNhap = @maPN"; ;
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@maPN", mpn);

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

        public float kiemTraGiaNhapCtnhDAL(string msp) // Kiểm tra gia nhap đã tồn tại trong ctnh
        {
            float giaNhap = -1; // Mặc định là -1 nếu không tìm thấy
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                string query = "select GiaNhap from ChiTietNhapHang where MaSanPham=@msp";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@msp", msp);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read()) // Đọc dòng đầu tiên (vì chỉ có 1 dòng)
                    {
                        giaNhap = float.Parse(reader["GiaNhap"].ToString());
                    }
                }

                reader.Close();
                conn.Close();
            }

            return giaNhap;
        }
    }
}
