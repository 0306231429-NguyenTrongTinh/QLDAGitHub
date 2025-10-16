using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string MaKhachHang { set; get; }
        public string HoTen { set; get; }
        public DateTime NgaySinh { set; get; }
        public string GioiTinh { set; get; }
        public string DiaChi { set; get; }
        public string SDT { set; get; }
        public string LoaiKhachHang { set; get; }
        public int DiemTichLuy { set; get; }
    }

}
