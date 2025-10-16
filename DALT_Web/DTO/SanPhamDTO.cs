using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public string MaSanPham { set; get; }
        public string TenSanPham { set; get; }
        public string MaLoai { set; get; }
        public float DonGia { set; get; }
        public int SoLuongTon { set; get; }
        public string DonViTinh { set; get; }
        public string MaNCC { set; get; }
        public DateTime? NgayHetHan { set; get; }
        public string TrangThai { set; get; }
    }
}
