using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class SanPhamAccess 
    {
        public List<string> checkMaSpDAL(SanPhamDTO sp)  // Tìm mã sản phẩm từ textbox 
        {
            List<string> dsSanPham = new List<string>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "SELECT MaSanPham FROM SanPham WHERE MaSanPham LIKE '%' + @MaSP + '%' ";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@MaSP", sp.MaSanPham);
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

        public List<string> LoadMaSpDAL() // Load mã sản phẩm lên combobox 
        {
            List<string> dsSanPham = new List<string>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            SqlCommand cm = new SqlCommand("SELECT MaSanPham from SanPham where TrangThai=N'Còn hàng'", conn);
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

        public List<string> LoadThongTinSpDAL(SanPhamDTO sp) // Load thông tin mã sản phẩm 
        {
            List<string> dsSanPham = new List<string>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "SELECT TenSanPham,DonGia,SoLuongTon,DonViTinh,MaLoai,MaNCC from SanPham where MaSanPham=@Masp";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@Masp", sp.MaSanPham);
            cm.Connection = conn;
            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                if (da.Read())
                {
                    dsSanPham.Add(da["TenSanPham"].ToString());
                    dsSanPham.Add(da["DonGia"].ToString());
                    dsSanPham.Add(da["SoLuongTon"].ToString());
                    dsSanPham.Add(da["DonViTinh"].ToString());
                    dsSanPham.Add(da["MaLoai"].ToString());
                    dsSanPham.Add(da["MaNCC"].ToString());
                }
                da.Close();
                conn.Close();

            }
            return dsSanPham;
        }

        public List<SanPhamDTO> loadSanPhamDAL()  // Load ds Sản phẩm
        {
            List<SanPhamDTO> dsSanPham = new List<SanPhamDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT * FROM SanPham WHERE TrangThai != N'Ngưng Bán'";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    SanPhamDTO sp = new SanPhamDTO();

                    sp.MaSanPham = da["MaSanPham"].ToString();
                    sp.TenSanPham = da["TenSanPham"].ToString();
                    sp.MaLoai = da["MaLoai"].ToString();
                    sp.DonGia = float.Parse(da["DonGia"].ToString());
                    sp.SoLuongTon = int.Parse(da["SoLuongTon"].ToString());
                    sp.DonViTinh = da["DonViTinh"].ToString();
                    sp.MaNCC = da["MaNCC"].ToString();
                    sp.NgayHetHan = da["NgayHetHan"] == DBNull.Value
                    ? (DateTime?)null
                    : DateTime.Parse(da["NgayHetHan"].ToString());
                    sp.TrangThai = da["TrangThai"].ToString();


                    dsSanPham.Add(sp);
                }
                da.Close();
                conn.Close();

            }
            return dsSanPham;
        }

        public List<SanPhamDTO> LoadSearchSpDAL(string tt, string value)  // Tìm thông tin SP
        {
            List<SanPhamDTO> sear = new List<SanPhamDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            SqlCommand cm = null;
            string query = "";


            switch (tt.ToLower())
            {
                case "masp":
                    query = "SELECT * FROM SanPham WHERE MaSanPham LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "tensp":
                    query = "SELECT * FROM SanPham WHERE TenSanPham LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "mancc":
                    query = "SELECT * FROM SanPham WHERE MaNCC LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "tt":
                    query = "SELECT * FROM SanPham WHERE TrangThai LIKE '%' + @value + '%'";
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
                    SanPhamDTO sp = new SanPhamDTO();

                    sp.MaSanPham = da["MaSanPham"].ToString();
                    sp.TenSanPham = da["TenSanPham"].ToString();
                    sp.MaLoai = da["MaLoai"].ToString();
                    sp.DonGia = float.Parse(da["DonGia"].ToString());
                    sp.SoLuongTon = int.Parse(da["SoLuongTon"].ToString());

                    sp.DonViTinh = da["DonViTinh"].ToString();
                    sp.MaNCC = da["MaNCC"].ToString();


                    sp.NgayHetHan = da["NgayHetHan"] == DBNull.Value
                    ? (DateTime?)null
                    : DateTime.Parse(da["NgayHetHan"].ToString());

                    sp.TrangThai = da["TrangThai"].ToString();


                    sear.Add(sp);
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


        public string themSpDAL(SanPhamDTO sp)   // Thêm san pham
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "INSERT INTO SanPham VALUES (@MaSanPham, @TenSanPham, @MaLoai,@DonGia,@SoLuongTon,@DonViTinh,@MaNCC,@NgayHetHan,@TrangThai)";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaSanPham", sp.MaSanPham);
            cm.Parameters.AddWithValue("@TenSanPham", sp.TenSanPham);
            cm.Parameters.AddWithValue("@MaLoai", sp.MaLoai);
            cm.Parameters.AddWithValue("@DonGia", sp.DonGia);
            cm.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
            cm.Parameters.AddWithValue("@DonViTinh", sp.DonViTinh);
            cm.Parameters.AddWithValue("@MaNCC", sp.MaNCC);
            cm.Parameters.AddWithValue("@NgayHetHan", sp.NgayHetHan);
            cm.Parameters.AddWithValue("@TrangThai", sp.TrangThai);
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
        public string xoaSpDAL(string msp) // Xóa san pham
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "UPDATE SanPham SET TrangThai = N'Ngưng Bán' WHERE MaSanPham = @maSP";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@maSP", msp);

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

        public string updateSpDAL(SanPhamDTO sp)  // Chỉnh sửa san pham
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE SanPham SET TenSanPham = @TenSanPham,MaLoai = @MaLoai," +
                "DonGia = @DonGia,SoLuongTon = @SoLuongTon,DonViTinh=@DonViTinh,MaNCC = @MaNCC,NgayHetHan=@NgayHetHan" +
                " WHERE MaSanPham = @MaSanPham";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.Parameters.AddWithValue("@MaSanPham", sp.MaSanPham);
            cm.Parameters.AddWithValue("@TenSanPham", sp.TenSanPham);
            cm.Parameters.AddWithValue("@MaLoai", sp.MaLoai);
            cm.Parameters.AddWithValue("@DonGia", sp.DonGia);
            cm.Parameters.AddWithValue("@SoLuongTon", sp.SoLuongTon);
            cm.Parameters.AddWithValue("@DonViTinh", sp.DonViTinh);
            cm.Parameters.AddWithValue("@MaNCC", sp.MaNCC);
            cm.Parameters.AddWithValue("@NgayHetHan", sp.NgayHetHan);
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

        public string updateSLtonDAL(int sl, string msp)  // update so luong ton san pham
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = @"
            UPDATE SanPham
            SET SoLuongTon =SoLuongTon - @sl
            WHERE MaSanPham = @masp"; ;
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@sl", sl);
            cm.Parameters.AddWithValue("@masp", msp);

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

        public string GenerateMaSpDonDAL() // Tạo mã SP tự động
        {
            string maSP = "SP001"; // mặc định nếu chưa có san pham nào
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT TOP 1 MaSanPham FROM SanPham ORDER BY MaSanPham DESC";
            SqlCommand cmd = new SqlCommand(query, conn);

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                string lastMaSP = result.ToString(); // ví dụ: SP009
                int number = int.Parse(lastMaSP.Substring(2)); // cắt lấy phần số: 009 => 9
                number++;
                maSP = "SP" + number.ToString("D3"); // format lại thành SP010, SP011...
            }

            conn.Close();
            return maSP;
        }

        public string capNhatTrangThaiDAL( string tt, string msp) // cap nhat trang thai sp
        {

            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE SanPham SET TrangThai = @TrangThai WHERE MaSanPham = @MaSP";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@TrangThai", tt);
            cm.Parameters.AddWithValue("@MaSP", msp);

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

        public string kiemTraiTonTaiPnDAL(SanPhamDTO sp)  // kiem tra sp ton tai
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "select * from SanPham where TenSanPham=@TenSanPham and MaLoai=@MaLoai and DonGia=@DonGia and MaNCC=@MaNCC";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@TenSanPham", sp.TenSanPham);
            cm.Parameters.AddWithValue("@MaLoai", sp.MaLoai);
            cm.Parameters.AddWithValue("@DonGia", sp.DonGia);
            cm.Parameters.AddWithValue("@MaNCC", sp.MaNCC);
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

        public int LoadSltSpDAL(string msp) // Load so luong ton tu mã sản phẩm 
        {
            int sl=0;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "SELECT SoLuongTon from SanPham where MaSanPham=@Masp";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@Masp", msp);
            cm.Connection = conn;
            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                if (da.Read())
                {
                    
                    sl= int.Parse(da["SoLuongTon"].ToString());
                   
                }
                da.Close();
                conn.Close();

            }
            return sl;
        }
    }
}
