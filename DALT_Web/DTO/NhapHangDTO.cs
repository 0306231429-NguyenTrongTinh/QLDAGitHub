using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapHangDTO
    {
        public string MaPhieuNhap { set; get; }
        public DateTime NgayNhap { set; get; }
        public string MaNhanVien { set; get; }
        public string MaNhaCungCap { set; get; }
        public float TongTien { set; get; }
        public string TrangThai { set; get; }
    }
}
