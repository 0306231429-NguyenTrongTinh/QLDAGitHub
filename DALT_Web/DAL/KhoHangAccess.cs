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
    public class KhoHangAccess
    {
        public List<KhoHangDTO> loadDsKhoHangDAL()  // Load danh sách KhoHang
        {
            List<KhoHangDTO> dsKhoH = new List<KhoHangDTO>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = @"SELECT SanPham.MaSanPham,SanPham.SoLuongTon,ChiTietNhapHang.SoLuong,ChiTietNhapHang.GiaNhap,SanPham.DonGia,NhapHang.NgayNhap
            FROM SanPham JOIN ChiTietNhapHang ON SanPham.MaSanPham = ChiTietNhapHang.MaSanPham 
            JOIN NhapHang ON NhapHang.MaPhieuNhap = ChiTietNhapHang.MaPhieuNhap WHERE ChiTietNhapHang.MaPhieuNhap IN
            (SELECT MaPhieuNhap FROM NhapHang WHERE TrangThai = N'Đã nhập')";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.CommandType = CommandType.Text;
            cm.Connection = conn;

            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
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

            }
            return dsKhoH;
        }

        public string xoaKhDAL(string msp) // Xóa KH
        {
            string kq = "";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();

            string query = "DELETE FROM KhoHang WHERE MaSanPham = @MaSanPham";
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

        public string updateKhoHangDAL(KhoHangDTO kh)  // Chỉnh sửa Kho Hang
        {
            string kq = null;
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            string query = "UPDATE KhoHang SET SoLuongTon = @SoLuongTon,SoLuongNhap = @SoLuongNhap," +
                "GiaNhap = @GiaNhap,GiaBan = @GiaBan,NgayCapNhat=@NgayCapNhat WHERE MaSanPham = @MaSanPham";
            SqlCommand cm = new SqlCommand(query, conn);

            cm.Parameters.AddWithValue("@SoLuongTon", kh.SoLuongTon);
            cm.Parameters.AddWithValue("@SoLuongNhap", kh.SoLuongNhap);
            cm.Parameters.AddWithValue("@GiaNhap", kh.GiaNhap);
            cm.Parameters.AddWithValue("@GiaBan", kh.GiaBan);
            cm.Parameters.AddWithValue("@NgayCapNhat", kh.NgayCapNhat);
            
            cm.Parameters.AddWithValue("@MaSanPham", kh.MaSanPham);
            
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
