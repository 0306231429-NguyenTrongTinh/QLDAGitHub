using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class TaiKhoanAccess 
    {
        public List<string> checkLoginDAL(TaiKhoanDTO tk) // Kiểm tra tài khoản đăng nhập 
        {

            List<string> user = new List<string>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "SELECT TenDangNhap,MatKhau,Quyen,MaNhanVien FROM TaiKhoan WHERE TenDangNhap=@user and MatKhau=@pass";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@user", tk.TenDangNhap);
            cm.Parameters.AddWithValue("@pass", tk.MatKhau);
            cm.Connection = conn;
            SqlDataReader rd = cm.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    user.Add(rd["Quyen"].ToString());
                    user.Add(rd["TenDangNhap"].ToString());
                    user.Add(rd["MatKhau"].ToString());
                    user.Add(rd["MaNhanVien"].ToString());
                }
                rd.Close();
                conn.Close();
            }
            else
            {
                user.Add("Tai khoan hoac mat khau khong chinh xac");
                return user;
            }
            return user;
        }

        public string updateMkDAL(string user, string mkCu, string mkMoi) // Đổi mật khẩu
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE TaiKhoan SET MatKhau = @passMoi WHERE TenDangNhap = @user AND MatKhau = @passCu";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@user", user);
            cm.Parameters.AddWithValue("@passCu", mkCu);
            cm.Parameters.AddWithValue("@passMoi", mkMoi);
            cm.Connection = conn;

            int rowsAffected = cm.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                kq = "dtc";
            }
            return kq;
        }


        public string ktTaiKhoanDAL(string user)  // Kiểm tra tên tài khoản đã tồn tại chưa
        {
            string kq = "ktt";
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap=@user ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", user);


                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) // Có dòng => tài khoản đã tồn tại
                {
                    kq = "tt";
                }
                reader.Close();
            }
            return kq;

        }

        public string themTkDAL(TaiKhoanDTO tk) // Thêm Tài Khoản 
        {

            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "INSERT INTO TaiKhoan VALUES (@MaTK,@MaNhanVien, @TenDangNhap, @MatKhau,@Quyen)";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaTK", tk.MaTK);
            cm.Parameters.AddWithValue("@MaNhanVien", tk.MaNhanVien);
            cm.Parameters.AddWithValue("@TenDangNhap", tk.TenDangNhap);
            cm.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
            cm.Parameters.AddWithValue("@Quyen", tk.Quyen);
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

        public List<TaiKhoanDTO> loadDsTaiKhoanDAL()  // Load danh sách tk
        {
            List<TaiKhoanDTO> dsTK = new List<TaiKhoanDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT * FROM TaiKhoan";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    TaiKhoanDTO tk = new TaiKhoanDTO();

                    tk.MaTK = da["MaTK"].ToString();
                    tk.MaNhanVien = da["MaNhanVien"].ToString();
                    tk.TenDangNhap = da["TenDangNhap"].ToString();
                    tk.MatKhau = da["MatKhau"].ToString();
                    tk.Quyen = da["Quyen"].ToString();

                    dsTK.Add(tk);
                }
                da.Close();
                conn.Close();

            }
            return dsTK;
        }

        public string xoaTkDAL(string mnv) // Xóa tk
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "DELETE FROM TaiKhoan WHERE MaNhanVien = @maNV";
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

        public string updateTkDAL(TaiKhoanDTO tk)  // Chỉnh sửa tk
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE TaiKhoan SET MaNhanVien = @MaNhanVien,TenDangNhap = @TenDangNhap," +
                "MatKhau = @MatKhau,Quyen = @Quyen WHERE MaTK = @MaTK";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.Parameters.AddWithValue("@MaNhanVien", tk.MaNhanVien);
            cm.Parameters.AddWithValue("@TenDangNhap", tk.TenDangNhap);
            cm.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
            cm.Parameters.AddWithValue("@Quyen", tk.Quyen);
            cm.Parameters.AddWithValue("@MaTK", tk.MaTK);
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

        public string GenerateMaNhanVienDAL() // Tạo MaTk tự động
        {
            string maTK = "Tk001"; 
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT TOP 1 MaTK FROM TaiKhoan ORDER BY MaTK DESC";
            SqlCommand cmd = new SqlCommand(query, conn);

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                string lastMaTK = result.ToString(); 
                int number = int.Parse(lastMaTK.Substring(2)); 
                number++;
                maTK = "TK" + number.ToString("D3"); 
            }

            conn.Close();
            return maTK;
        }

        public string capNhatTrangThaiDAL(string quyen, string mtk) // cap nhat trang thai tk
        {

            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE TaiKhoan SET Quyen = @Quyen WHERE MaTK = @MaTK";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@Quyen", quyen);
            cm.Parameters.AddWithValue("@MaTK", mtk);

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
    }
}
