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
    public class NhanVienAccess
    {
        public List<string> LoadMaNvDAL() // Load mã nv lên cbb 
        {
            List<string> dsMaNv = new List<string>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            SqlCommand cm = new SqlCommand("SELECT MaNhanVien from NhanVien", conn);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;
            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    dsMaNv.Add(da["MaNhanVien"].ToString());
                }
                da.Close();
                conn.Close();

            }

            return dsMaNv;
        }

        public string GenerateMaNhanVienDAL() // Tạo MaNV tự động
        {
            string maNV = "NV001"; // mặc định nếu chưa có nhan vien nào
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT TOP 1 MaNhanVien FROM NhanVien ORDER BY MaNhanVien DESC";
            SqlCommand cmd = new SqlCommand(query, conn);

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                string lastMaNV = result.ToString(); // ví dụ: NV009
                int number = int.Parse(lastMaNV.Substring(2)); // cắt lấy phần số: 009 => 9
                number++;
                maNV = "NV" + number.ToString("D3"); // format lại thành NV010, NV011...
            }

            conn.Close();
            return maNV;
        }
        public string themNvDAL(NhanVienDTO nv) // Thêm Nhân Viên
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "INSERT INTO NhanVien VALUES (@MaNhanVien, @HoTen, @NgaySinh,@GioiTinh,@SoDienThoai,@ChucVu,@Luong,@TrangThai)";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaNhanVien", nv.MaNhanVien);
            cm.Parameters.AddWithValue("@HoTen", nv.HoTen);
            cm.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
            cm.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
            cm.Parameters.AddWithValue("@SoDienThoai", nv.SoDienThoai);
            cm.Parameters.AddWithValue("@ChucVu", nv.ChucVu);
            cm.Parameters.AddWithValue("@Luong", nv.Luong);
            cm.Parameters.AddWithValue("@TrangThai", nv.TrangThai);
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


       
        public string xoaNvDAL(string mnv) // Xóa Nv
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "UPDATE NhanVien SET TrangThai=N'Nghỉ' WHERE MaNhanVien = @maNV";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@maNv", mnv);

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

        public string updateNvDAL(NhanVienDTO nv)  // Chỉnh sửa HD
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE NhanVien SET HoTen = @HoTen,NgaySinh = @NgaySinh," +
                "GioiTinh = @GioiTinh,SoDienThoai = @SoDienThoai,ChucVu=@ChucVu,Luong=@Luong,TrangThai=@TrangThai WHERE MaNhanVien = @MaNhanVien";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.Parameters.AddWithValue("@HoTen", nv.HoTen);
            cm.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
            cm.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
            cm.Parameters.AddWithValue("@SoDienThoai", nv.SoDienThoai);
            cm.Parameters.AddWithValue("@ChucVu", nv.ChucVu);
            cm.Parameters.AddWithValue("@Luong", nv.Luong);
            cm.Parameters.AddWithValue("@TrangThai", nv.TrangThai);
            cm.Parameters.AddWithValue("@MaNhanVien", nv.MaNhanVien);
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


        public List<string> LoadMaNvTkDAL() // Load các MaNV chưa có Tài Khoản
        {
            List<string> dsMaNv = new List<string>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            SqlCommand cm = new SqlCommand("SELECT MaNhanVien FROM NhanVien WHERE NOT EXISTS ( SELECT 1  FROM TaiKhoan  WHERE TaiKhoan.MaNhanVien = NhanVien.MaNhanVien )", conn);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;
            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    dsMaNv.Add(da["MaNhanVien"].ToString());
                }
                da.Close();
                conn.Close();

            }

            return dsMaNv;
        }



        public string LoadQuyenNvDAL(string mnv) // Cho biết quyền của Nhân Viên
        {
            string kq = "";
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                string query = "SELECT ChucVu FROM NhanVien WHERE MaNhanVien=@mnv ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mnv", mnv);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        kq = reader["ChucVu"].ToString();
                    }
                    reader.Close();
                    conn.Close();
                }
            }
            return kq;
        }

        public List<NhanVienDTO> loadDsNhanVienDAL()  // Load danh sách NV
        {
            List<NhanVienDTO> dsNV = new List<NhanVienDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT * FROM NhanVien where TrangThai=N'Đang làm'";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    NhanVienDTO nv = new NhanVienDTO();

                    nv.MaNhanVien = da["MaNhanVien"].ToString();
                    nv.HoTen = da["HoTen"].ToString();
                    nv.NgaySinh = DateTime.Parse(da["NgaySinh"].ToString());
                    nv.GioiTinh = da["GioiTinh"].ToString();
                    nv.SoDienThoai = da["SoDienThoai"].ToString();
                   
                    nv.ChucVu = da["ChucVu"].ToString();
                    nv.Luong = float.Parse(da["Luong"].ToString());
                    nv.TrangThai = da["TrangThai"].ToString();

                    dsNV.Add(nv);
                }
                da.Close();
                conn.Close();

            }
            return dsNV;
        }

        public List<NhanVienDTO> LoadSearchNvDAL(string tt, string value)  // Tìm thông tin nv
        {
            List<NhanVienDTO> sear = new List<NhanVienDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            SqlCommand cm = null;
            string query = "";


            switch (tt.ToLower())
            {
                case "manv":
                    query = "SELECT * FROM NhanVien WHERE MaNhanVien LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "ht":
                    query = "SELECT * FROM NhanVien WHERE HoTen LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "sdt":
                    query = "SELECT * FROM NhanVien WHERE SoDienThoai LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "tt":
                    query = "SELECT * FROM NhanVien WHERE TrangThai LIKE '%' + @value + '%'";
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
                    NhanVienDTO nv = new NhanVienDTO();

                    nv.MaNhanVien = da["MaNhanVien"].ToString();
                    nv.HoTen = da["HoTen"].ToString();
                    nv.NgaySinh = DateTime.Parse(da["NgaySinh"].ToString());
                    nv.GioiTinh = da["GioiTinh"].ToString();
                    nv.SoDienThoai = da["SoDienThoai"].ToString();

                    nv.ChucVu = da["ChucVu"].ToString();
                    nv.Luong = float.Parse(da["Luong"].ToString());
                    nv.TrangThai = da["TrangThai"].ToString();

                    sear.Add(nv);
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

        public string ktSDTNvDAL(string sdt)  // Kiểm tra tồn tại số điện thoại
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();

            try
            {
                conn.Open();

                string query = "SELECT * FROM NhanVien WHERE SoDienThoai = @SDT";
                SqlCommand cm = new SqlCommand(query, conn);
                cm.Parameters.AddWithValue("@SDT", sdt);

                SqlDataReader da = cm.ExecuteReader();

                if (da.HasRows)
                {
                    kq = "tt";
                }
                else
                {
                    kq = "ctt";
                }

                da.Close();
            }
            catch (Exception ex)
            {
                kq = "Lỗi: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return kq;
        }

        public List<string> LoadThongTinNvDAL(string manv) // Load thông tin mã nhan vien
        {
            List<string> dsNV = new List<string>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "SELECT HoTen,NgaySinh,GioiTinh,SoDienThoai,ChucVu,Luong,TrangThai from NhanVien where MaNhanVien=@MaNhanVien";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@MaNhanVien", manv);
            cm.Connection = conn;
            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                if (da.Read())
                {
                    dsNV.Add(da["HoTen"].ToString());
                    dsNV.Add(da["NgaySinh"].ToString());
                    dsNV.Add(da["GioiTinh"].ToString());
                    dsNV.Add(da["SoDienThoai"].ToString());
                    dsNV.Add(da["ChucVu"].ToString());
                    dsNV.Add(da["Luong"].ToString());
                    dsNV.Add(da["TrangThai"].ToString());
                }
                da.Close();
                conn.Close();

            }
            return dsNV;
        }
    }
}
