using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public string MaHoaDon { set; get; }
        public DateTime NgayLap { set; get; }
        public string MaNhanVien { set; get; }
        public string MaKhachHang { set; get; }
        public float TongTien { set; get; }
        public string HinhThuc { set; get; }
        public string TrangThai { set; get; }
    }
}
