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
    public class LoaiSanPhamAccess 
    {
        public List<LoaiSanPhamDTO> LoadLspDAL() // load ds LSP
        {

            List<LoaiSanPhamDTO> dsLSP = new List<LoaiSanPhamDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT * FROM LoaiSanPham where TrangThai = 1";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    LoaiSanPhamDTO lsp = new LoaiSanPhamDTO();

                    lsp.MaLoai = da["MaLoai"].ToString();
                    lsp.TenLoai = da["TenLoai"].ToString();



                    dsLSP.Add(lsp);
                }
                da.Close();
                conn.Close();

            }
            return dsLSP;
        }
        public string GenerateMaLspDAL() // Tạo MaLSP tự động
        {
            string maNCC = "LSP001"; // mặc định nếu chưa có lsp nào
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "SELECT TOP 1 MaLoai FROM LoaiSanPham ORDER BY MaLoai DESC";
            SqlCommand cmd = new SqlCommand(query, conn);

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                string lastMaNCC = result.ToString();
                int number = int.Parse(lastMaNCC.Substring(3));
                number++;
                maNCC = "LSP" + number.ToString("D3");
            }

            conn.Close();
            return maNCC;
        }

        public string themLspDAL(LoaiSanPhamDTO lsp) // Thêm LSP
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "INSERT INTO LoaiSanPham VALUES (@MaLoai, @TenLoai)";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaLoai", lsp.MaLoai);
            cm.Parameters.AddWithValue("@TenLoai", lsp.TenLoai);
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
        public string xoaLspDAL(string mlsp) // Xóa LSP
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "UPDATE LoaiSanPham SET TrangThai=0 WHERE MaLoai = @MaLoai";
            SqlCommand cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@MaLoai", mlsp);

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

        public string updateMaLspDAL(LoaiSanPhamDTO lsp) // Chỉnh sửa lsp
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE LoaiSanPham SET MaLoai = @MaLoai,TenLoai =@TenLoai  WHERE MaLoai = @MaLoai";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.Parameters.AddWithValue("@MaLoai", lsp.MaLoai);
            cm.Parameters.AddWithValue("@TenLoai", lsp.TenLoai);
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

        public List<LoaiSanPhamDTO> LoadSearchLspDAL(string tt, string value)  // Tìm thông tin LSP
        {
            List<LoaiSanPhamDTO> sear = new List<LoaiSanPhamDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            SqlCommand cm = null;
            string query = "";


            switch (tt.ToLower())
            {
                case "ma":
                    query = "SELECT * FROM LoaiSanPham WHERE MaLoai LIKE '%' + @value + '%'";
                    cm = new SqlCommand(query, conn);
                    cm.Parameters.AddWithValue("@value", value);
                    break;

                case "ten":
                    query = "SELECT * FROM LoaiSanPham WHERE TenLoai LIKE '%' + @value + '%'";
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
                    LoaiSanPhamDTO lsp = new LoaiSanPhamDTO();

                    lsp.MaLoai = da["MaLoai"].ToString();
                    lsp.TenLoai = da["TenLoai"].ToString();
                    sear.Add(lsp);
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
    }
}
