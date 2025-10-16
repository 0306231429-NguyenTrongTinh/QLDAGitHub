using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamAccess mspA = new SanPhamAccess();
        public List<string> checkMaspBLL(SanPhamDTO sp)
        {
            List<string> info = mspA.checkMaSpDAL(sp);
            return info;
        }

        public List<string> LoadMaspBLL()
        {
            List<string> info = mspA.LoadMaSpDAL();
            return info;
        }
        public List<string> LoadThongTinSpBLL(SanPhamDTO sp)
        {
            List<string> dsSanPham = new List<string>();
            dsSanPham = mspA.LoadThongTinSpDAL(sp);
            return dsSanPham;
        }
        public List<SanPhamDTO> loadSanPhamBLL()
        {
            List<SanPhamDTO> dsSanPham = mspA.loadSanPhamDAL();
            return dsSanPham;
        }

        public List<SanPhamDTO> LoadSearchSpBLL(string tt, string value)
        {
            List<SanPhamDTO> dsSanPham = mspA.LoadSearchSpDAL(tt, value);
            return dsSanPham;
        }

        public string themSpBLL(SanPhamDTO sp)
        {
            string info = mspA.themSpDAL(sp);
            return info;
        }

        public string xoaSpBLL(string msp)
        {
            string info = mspA.xoaSpDAL(msp);
            return info;
        }

        public string updateSpBLL(SanPhamDTO sp)
        {
            string info = mspA.updateSpDAL(sp);
            return info;
        }

        public string updateSLtonBLL(int sl, string msp)
        {
            string info = mspA.updateSLtonDAL(sl, msp);
            return info;
        }

        public string GenerateMaSpDonDAL()
        {
            string info = mspA.GenerateMaSpDonDAL();
            return info;
        }

        public string capNhatTrangThaiBLL(string tt, string msp)
        {
            string info = mspA.capNhatTrangThaiDAL(tt,msp);
            return info;
        }

        public string kiemTraiTonTaiPnBLL(SanPhamDTO sp)
        {
            string info = mspA.kiemTraiTonTaiPnDAL(sp);
            return info;
        }

        public int LoadSltSpBLL(string msp)
        {
            int info = mspA.LoadSltSpDAL(msp);
            return info;
        }
    }
}
