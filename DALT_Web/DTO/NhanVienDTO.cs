using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string MaNhanVien { set; get; }
        public string HoTen { set; get; }
        public DateTime NgaySinh { set; get; }
        public string GioiTinh { set; get; }
        public string SoDienThoai { set; get; }
        public string ChucVu { set; get; }
        public float Luong { set; get; }
        public string TrangThai { set; get; }
    }
}
