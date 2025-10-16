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
    public class NhapHangAccess 
    {
        public List<NhapHangDTO> loadDsNhapHangDAL()  // Load danh sách nhap hang
        {
            List<NhapHangDTO> dsNH = new List<NhapHangDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT * FROM NhapHang";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    NhapHangDTO nh = new NhapHangDTO();
                    nh.MaPhieuNhap= da["MaPhieuNhap"].ToString();
                    nh.NgayNhap= DateTime.Parse(da["NgayNhap"].ToString());
                    nh.MaNhanVien= da["MaNhanVien"].ToString();
                    nh.MaNhaCungCap= da["MaNhaCungCap"].ToString();
                    nh.TongTien= float.Parse(da["TongTien"].ToString());
                    nh.TrangThai = da["TrangThai"].ToString();


                    dsNH.Add(nh);
                }
                da.Close();
                conn.Close();

            }
            return dsNH;
        }

        public string GenerateMaNhapHangDAL() // Tạo mã NH tự động
        {
            string maPN = "PN001"; 
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT TOP 1 MaPhieuNhap FROM NhapHang ORDER BY MaPhieuNhap DESC";
            SqlCommand cmd = new SqlCommand(query, conn);

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                string lastMaPN = result.ToString(); 
                int number = int.Parse(lastMaPN.Substring(2)); 
                number++;
                maPN = "PN" + number.ToString("D3"); 
            }

            conn.Close();
            return maPN;
        }
        public string themPnDAL(NhapHangDTO pn)   // Thêm nhap hang
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "INSERT INTO NhapHang VALUES (@MaPhieuNhap, @NgayNhap, @MaNhanVien,@MaNhaCungCap,@TongTien,@TrangThai)";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaPhieuNhap", pn.MaPhieuNhap);
            cm.Parameters.AddWithValue("@NgayNhap", pn.NgayNhap);
            cm.Parameters.AddWithValue("@MaNhanVien", pn.MaNhanVien);
            cm.Parameters.AddWithValue("@MaNhaCungCap", pn.MaNhaCungCap);
            cm.Parameters.AddWithValue("@TongTien", pn.TongTien);
            cm.Parameters.AddWithValue("@TrangThai", pn.TrangThai);
            
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
        public string xoaPnDAL(string mpn) // Xóa NH
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "DELETE FROM NhapHang WHERE MaPhieuNhap = @maPN";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@maPN", mpn);

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

        public string updatePnDAL(NhapHangDTO pn)  // Chỉnh sửa NH
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE NhapHang SET NgayNhap = @NgayNhap," +
                "MaNhaCungCap = @MaNhaCungCap,TongTien=@TongTien,TrangThai = @TrangThai WHERE MaPhieuNhap = @MaPhieuNhap";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaPhieuNhap", pn.MaPhieuNhap);
            cm.Parameters.AddWithValue("@NgayNhap", pn.NgayNhap);
            cm.Parameters.AddWithValue("@MaNhaCungCap", pn.MaNhaCungCap);
            cm.Parameters.AddWithValue("@TongTien", pn.TongTien);
            cm.Parameters.AddWithValue("@TrangThai", pn.TrangThai);
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

        public List<NhapHangDTO> LoadSearchPnDAL(string tt, string value)  // Tìm thông tin PN
        {
            List<NhapHangDTO> sear = new List<NhapHangDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            SqlCommand cm = null;
            string query = "";


            switch (tt.ToLower())
            {
                case "mapn":
                    query = "SELECT * FROM NhapHang WHERE MaPhieuNhap LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "manv":
                    query = "SELECT * FROM NhapHang WHERE MaNhanVien LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "mancc":
                    query = "SELECT * FROM NhapHang WHERE MaNhaCungCap LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "tt":
                    query = "SELECT * FROM NhapHang WHERE TrangThai LIKE '%' + @value + '%'";
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
                    NhapHangDTO nh = new NhapHangDTO();
                    nh.MaPhieuNhap = da["MaPhieuNhap"].ToString();
                    nh.NgayNhap = DateTime.Parse(da["NgayNhap"].ToString());
                    nh.MaNhanVien = da["MaNhanVien"].ToString();
                    nh.MaNhaCungCap = da["MaNhaCungCap"].ToString();
                    nh.TongTien = float.Parse(da["TongTien"].ToString());
                    nh.TrangThai = da["TrangThai"].ToString();
                    sear.Add(nh);
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

        public string capNhatTrangThaiDAL(string tt, string mpn) // cap nhat trang thai pn
        {

            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE NhapHang SET TrangThai = @TrangThai WHERE MaPhieuNhap = @MaPN";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@TrangThai", tt);
            cm.Parameters.AddWithValue("@MaPN", mpn);

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

        public List<string> LoadMaPnDAL() // Load mã phieu nhap lên combobox 
        {
            List<string> dsPN = new List<string>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            SqlCommand cm = new SqlCommand("SELECT MaPhieuNhap from NhapHang where TrangThai = N'Đang chờ' ", conn);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;
            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    dsPN.Add(da["MaPhieuNhap"].ToString());
                }
                da.Close();
                conn.Close();

            }
            return dsPN;
        }

        public string kiemTraiTonTaiPnDAL(NhapHangDTO pn)  // kiem tra pn ton tai
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "select * from NhapHang where NgayNhap=@NgayNhap and MaNhanVien=@MaNhanVien and MaNhaCungCap=@MaNhaCungCap and TrangThai=@TrangThai";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaNhanVien", pn.MaNhanVien);
            cm.Parameters.AddWithValue("@NgayNhap", pn.NgayNhap);
            cm.Parameters.AddWithValue("@MaNhaCungCap", pn.MaNhaCungCap);
            cm.Parameters.AddWithValue("@TrangThai", pn.TrangThai);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            SqlDataReader rd = cm.ExecuteReader();
            if (rd.HasRows)
            {
                kq = "tt";
            }
            else
            {
                return "ktt";
            }
            return kq;
        }

        
    }
}
