using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class ChiTietHoaDonBLL
    {
        ChiTietHoaDonAccess cthdA = new ChiTietHoaDonAccess();
        public List<ChiTietHoaDonDTO> loadCthdBLL(string value)
        {
            List<ChiTietHoaDonDTO> cthd = cthdA.loadCthdDAL(value);
            return cthd;
        }
        public string themCthdBLL(ChiTietHoaDonDTO cthd)
        {
            string info = cthdA.themCthdDAL(cthd);
            return info;
        }

        public string xoaCthdBLL(string mhd)
        {
            string info = cthdA.xoaCthdDAL(mhd);
            return info;
        }

        public string updCthd_HD_BLL(string mhd)
        {
            string info = cthdA.updCthd_HD_DAL(mhd);
            return info;
        }

        public string updateCthdBLL(ChiTietHoaDonDTO cthd)
        {
            string info = cthdA.updateCthdDAL(cthd);
            return info;
        }

        public string kiemTraSpCthdBLL(string mhd, string msp)
        {
            string info = cthdA.kiemTraSpCthdDAL(mhd, msp);
            return info;
        }

        public string maKH_maHdBLL(string mhd)
        {
            string info = cthdA.maKH_maHdDAL(mhd);
            return info;
        }

        public float kiemTraThanhTienCthdBLL(string mhd, string msp)
        {
            float tt = cthdA.kiemTraThanhTienCthdDAL(mhd, msp);
            return tt;
        }

        public int LoadSlCthdBLL(string mhd, string msp)
        {
            int info = cthdA.LoadSlCthdDAL(mhd, msp);
            return info;
        }

        public string xoaRowCthdBLL(string maHD, string maSP)
        {
            string info = cthdA.xoaRowCthdDAL(maHD, maSP);
            return info;
        }
    }
}
