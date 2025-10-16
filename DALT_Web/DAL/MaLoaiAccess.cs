using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class MaLoaiAccess 
    {

        public List<string> LoadMaLoaiDAL()  // Load mã loại lên cbb
        {
            List<string> dsMaLoai = new List<string>();
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            SqlCommand cm = new SqlCommand("SELECT MaLoai from LoaiSanPham", conn);
            cm.CommandType = CommandType.Text;
            cm.Connection = conn;
            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    dsMaLoai.Add(da["MaLoai"].ToString());
                }
                da.Close();
                conn.Close();

            }
            return dsMaLoai;
        }

        public string LoadTenMaLoaiDAL(string ml)  // Load ten mã loại 
        {
            string tenLoai="";
            SqlConnection conn = SqlConnectionData.connect();
            conn.Open();
            SqlCommand cm = new SqlCommand("SELECT TenLoai from LoaiSanPham where MaLoai=@MaLoai", conn);
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@MaLoai", ml);
            cm.Connection = conn;
            SqlDataReader da = cm.ExecuteReader();
            if (da.HasRows)
            {
                while (da.Read())
                {
                    tenLoai=da["TenLoai"].ToString();
                }
                da.Close();
                conn.Close();

            }
            return tenLoai;
        }
    }
}
