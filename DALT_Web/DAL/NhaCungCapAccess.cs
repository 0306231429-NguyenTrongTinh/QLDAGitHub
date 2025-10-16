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
    public class NhaCungCapAccess 
    {
        public List<string> LoadMaNccDAL()   // Load mã NCC lên cbb
        {
            List<string> dsNcc = new List<string>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            SqlCommand cm = new SqlCommand("SELECT MaNhaCungCap from NhaCungCap", conn);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;
            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    dsNcc.Add(da["MaNhaCungCap"].ToString());
                }
                da.Close();
                conn.Close();

            }
            return dsNcc;
        }

        public List<NhaCungCapDTO> loadNccDAL()  // Load ds NCC
        {
            List<NhaCungCapDTO> dsNCC = new List<NhaCungCapDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT * FROM NhaCungCap  where TrangThai = 1";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    NhaCungCapDTO ncc = new NhaCungCapDTO();

                    ncc.MaNhaCungCap = da["MaNhaCungCap"].ToString();
                    ncc.TenNhaCungCap = da["TenNhaCungCap"].ToString();
                    ncc.SoDienThoai = da["SoDienThoai"].ToString();
                    ncc.DiaChi = da["DiaChi"].ToString();


                    dsNCC.Add(ncc);
                }
                da.Close();
                conn.Close();

            }
            return dsNCC;
        }
        public string GenerateMaNccDAL() // Tạo MaNCC tự động
        {
            string maNCC = "NCC001"; // mặc định nếu chưa có ncc nào
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT TOP 1 MaNhaCungCap FROM NhaCungCap ORDER BY MaNhaCungCap DESC";
            SqlCommand cmd = new SqlCommand(query, conn);

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                string lastMaNCC = result.ToString();
                int number = int.Parse(lastMaNCC.Substring(3));
                number++;
                maNCC = "NCC" + number.ToString("D3");
            }

            conn.Close();
            return maNCC;
        }

        public string themNccDAL(NhaCungCapDTO ncc) // Thêm NCC
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "INSERT INTO NhaCungCap VALUES (@MaNhaCungCap, @TenNhaCungCap, @SoDienThoai,@DiaChi)";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaNhaCungCap", ncc.MaNhaCungCap);
            cm.Parameters.AddWithValue("@TenNhaCungCap", ncc.TenNhaCungCap);
            cm.Parameters.AddWithValue("@SoDienThoai", ncc.SoDienThoai);
            cm.Parameters.AddWithValue("@DiaChi", ncc.DiaChi);
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

        public string xoaNccDAL(string mncc) // Xóa NCC
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "UPDATE NhaCungCap SET TrangThai=0 WHERE MaNhaCungCap = @MaNhaCungCap";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaNhaCungCap", mncc);

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
        public string updateMaNccDAL(NhaCungCapDTO ncc) // Chỉnh sửa ncc
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE NhaCungCap SET MaNhaCungCap = @MaNhaCungCap,TenNhaCungCap = @TenNhaCungCap" +
                ",SoDienThoai=@SoDienThoai,DiaChi=@DiaChi WHERE MaNhaCungCap = @MaNhaCungCap";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.Parameters.AddWithValue("@MaNhaCungCap", ncc.MaNhaCungCap);
            cm.Parameters.AddWithValue("@TenNhaCungCap", ncc.TenNhaCungCap);
            cm.Parameters.AddWithValue("@SoDienThoai", ncc.SoDienThoai);
            cm.Parameters.AddWithValue("@DiaChi", ncc.DiaChi);
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
        public List<NhaCungCapDTO> LoadSearchNccDAL(string tt, string value)  // Tìm thông tin NCC
        {
            List<NhaCungCapDTO> sear = new List<NhaCungCapDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            SqlCommand cm = null;
            string query = "";


            switch (tt.ToLower())
            {
                case "ma":
                    query = "SELECT * FROM NhaCungCap WHERE MaNhaCungCap LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "ten":
                    query = "SELECT * FROM NhaCungCap WHERE TenNhaCungCap LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "dt":
                    query = "SELECT * FROM NhaCungCap WHERE SoDienThoai LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "dc":
                    query = "SELECT * FROM NhaCungCap WHERE DiaChi LIKE '%' + @value + '%'";
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
                    NhaCungCapDTO ncc = new NhaCungCapDTO();

                    ncc.MaNhaCungCap = da["MaNhaCungCap"].ToString();
                    ncc.TenNhaCungCap = da["TenNhaCungCap"].ToString();
                    ncc.SoDienThoai = da["SoDienThoai"].ToString();
                    ncc.DiaChi = da["DiaChi"].ToString();


                    sear.Add(ncc);
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

        public List<string> LoadThongTinNccDAL(string ncc)  // Load thông tin NCC từ MaNCC
        {
            List<string> dsNCC = new List<string>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "SELECT TenNhaCungCap,SoDienThoai,DiaChi from NhaCungCap where MaNhaCungCap=@MaNCC";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@MaNCC", ncc);
            cm.Connection = conn;
            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                if (da.Read())
                {
                    dsNCC.Add(da["TenNhaCungCap"].ToString());
                    dsNCC.Add(da["SoDienThoai"].ToString());
                    dsNCC.Add(da["DiaChi"].ToString());

                }
                da.Close();
                conn.Close();

            }
            return dsNCC;
        }
    }
}
