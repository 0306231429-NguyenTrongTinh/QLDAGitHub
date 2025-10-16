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
    public class KhachHangAccess 
    {
        public List<KhachHangDTO> loadKhachHangDAL()  // Load danh sách khách hàng 
        {
            List<KhachHangDTO> dsKhachHang = new List<KhachHangDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT * FROM KhachHang where DiemTichLuy >=0";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    KhachHangDTO kh = new KhachHangDTO();

                    kh.MaKhachHang = da["MaKhachHang"].ToString();
                    kh.HoTen = da["HoTen"].ToString();
                    kh.NgaySinh = DateTime.Parse(da["NgaySinh"].ToString());
                    kh.GioiTinh = da["GioiTinh"].ToString();
                    kh.DiaChi = da["DiaChi"].ToString();
                    kh.SDT = da["SDT"].ToString();
                    kh.DiemTichLuy = int.Parse(da["DiemTichLuy"].ToString());
                    kh.LoaiKhachHang = da["LoaiKhachHang"].ToString();


                    dsKhachHang.Add(kh);
                }
                da.Close();
                conn.Close();

            }
            return dsKhachHang;
        }

        public List<string> LoadMaKHDAL()  // Load MaKH lên cbb 
        {
            List<string> dsMaKH = new List<string>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            SqlCommand cm = new SqlCommand("SELECT MaKhachHang from KhachHang", conn);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;
            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    dsMaKH.Add(da["MaKhachHang"].ToString());
                }
                da.Close();
                conn.Close();

            }
            return dsMaKH;
        }

        public List<string> LoadThongTinKHDAL(KhachHangDTO kh)  // Load thông tin khách hàng từ MaKH
        {
            List<string> dsKhachHang = new List<string>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "SELECT MaKhachHang,HoTen,SDT from KhachHang where MaKhachHang=@Makh";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@Makh", kh.MaKhachHang);
            cm.Connection = conn;
            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                if (da.Read())
                {
                    dsKhachHang.Add(da["MaKhachHang"].ToString());
                    dsKhachHang.Add(da["HoTen"].ToString());
                    dsKhachHang.Add(da["SDT"].ToString());

                }
                da.Close();
                conn.Close();

            }
            return dsKhachHang;
        }

        


        public string themKhDAL(KhachHangDTO kh)   // Thêm khach hang
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "INSERT INTO KhachHang VALUES (@MaKhachHang, @HoTen, @NgaySinh,@GioiTinh,@DiaChi,@SDT,@LoaiKhachHang,@DiemTichLuy)";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaKhachHang", kh.MaKhachHang);
            cm.Parameters.AddWithValue("@HoTen", kh.HoTen);
            cm.Parameters.AddWithValue("@NgaySinh", kh.NgaySinh);
            cm.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);
            cm.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
            cm.Parameters.AddWithValue("@SDT", kh.SDT);
            cm.Parameters.AddWithValue("@LoaiKhachHang", kh.LoaiKhachHang);
            cm.Parameters.AddWithValue("@DiemTichLuy", kh.DiemTichLuy);
            
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
        public string xoaKhDAL(string mkh) // Xóa khach hang
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "UPDATE KhachHang SET DiemTichLuy= -1 WHERE MaKhachHang = @MaKhachHang";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaKhachHang", mkh);

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

        public string updateKhDAL(KhachHangDTO kh)  // Chỉnh sửa khach hang
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE KhachHang SET MaKhachHang = @MaKhachHang,HoTen = @HoTen," +
                "NgaySinh = @NgaySinh,GioiTinh = @GioiTinh,DiaChi=@DiaChi,SDT = @SDT,LoaiKhachHang=@LoaiKhachHang," +
                "DiemTichLuy=@DiemTichLuy WHERE MaKhachHang = @MaKhachHang";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.Parameters.AddWithValue("@MaKhachHang", kh.MaKhachHang);
            cm.Parameters.AddWithValue("@HoTen", kh.HoTen);
            cm.Parameters.AddWithValue("@NgaySinh", kh.NgaySinh);
            cm.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);
            cm.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
            cm.Parameters.AddWithValue("@SDT", kh.SDT);
            cm.Parameters.AddWithValue("@LoaiKhachHang", kh.LoaiKhachHang);
            cm.Parameters.AddWithValue("@DiemTichLuy", kh.DiemTichLuy);
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


        public string GenerateMaKhDAL() // Tạo mã kh tự động
        {
            string maKH = "KH001"; // mặc định nếu chưa có khach hang nào
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT TOP 1 MaKhachHang FROM KhachHang ORDER BY MaKhachHang DESC";
            SqlCommand cmd = new SqlCommand(query, conn);

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                string lastMaKH = result.ToString(); // ví dụ: KH009
                int number = int.Parse(lastMaKH.Substring(2)); // cắt lấy phần số: 009 => 9
                number++;
                maKH = "KH" + number.ToString("D3"); // format lại thành KH010, KH011...
            }

            conn.Close();
            return maKH;
        }

        public string ktSDTKhDAL(string sdt)  // Kiểm tra tồn tại số điện thoại
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();

            try
            {
                conn.Open();

                string query = "SELECT * FROM KhachHang WHERE SDT = @SDT";
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

        public List<KhachHangDTO> LoadSearchKhDAL(string tt, string value)  // Tìm thông tin KH
        {
            List<KhachHangDTO> sear = new List<KhachHangDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            SqlCommand cm = null;
            string query = "";


            switch (tt.ToLower())
            {
                case "makh":
                    query = "SELECT * FROM KhachHang WHERE MaKhachHang LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "ht":
                    query = "SELECT * FROM KhachHang WHERE HoTen LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "dc":
                    query = "SELECT * FROM KhachHang WHERE DiaChi LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "sdt":
                    query = "SELECT * FROM KhachHang WHERE SDT LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "tv":
                    query = "SELECT * FROM KhachHang WHERE LoaiKhachHang LIKE '%' + @value + '%'";
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
                    KhachHangDTO kh = new KhachHangDTO();

                    kh.MaKhachHang = da["MaKhachHang"].ToString();
                    kh.HoTen = da["HoTen"].ToString();
                    kh.NgaySinh = DateTime.Parse(da["NgaySinh"].ToString());
                    kh.GioiTinh = da["GioiTinh"].ToString();
                    kh.DiaChi = da["DiaChi"].ToString();
                    kh.SDT = da["SDT"].ToString();
                    kh.DiemTichLuy = int.Parse(da["DiemTichLuy"].ToString());
                    kh.LoaiKhachHang = da["LoaiKhachHang"].ToString();
                    sear.Add(kh);
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


        public string updateDTLKhDAL(int dtl,string mkh)  // diem tich luy
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE KhachHang SET DiemTichLuy= DiemTichLuy + @DiemTichLuy WHERE MaKhachHang = @MaKhachHang ";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@DiemTichLuy", dtl);
            cm.Parameters.AddWithValue("@MaKhachHang", mkh);
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


        public int loadDTLKhachHangDAL(string mkh)  // Load dtl khách hàng 
        {
            int dtl = 0;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT DiemTichLuy FROM KhachHang where MaKhachHang=@MaKhachHang";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaKhachHang", mkh);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    
                    dtl = int.Parse(da["DiemTichLuy"].ToString());
                }
                da.Close();
                conn.Close();

            }
            return dtl;
        }
    }
}
