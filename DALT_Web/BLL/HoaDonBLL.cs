using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonAccess hdAc = new HoaDonAccess();

        public List<HoaDonDTO> loadDsHoaDonBLL()
        {
            List<HoaDonDTO> hd = hdAc.loadDsHoaDonDAL();
            return hd;
        }

        public List<HoaDonDTO> LoadSearchHdBLL(string tt, string value)
        {
            List<HoaDonDTO> info = hdAc.LoadSearchHdDAL(tt, value);
            return info;
        }

        public  string GenerateMaHoaDonBLL()
        {
            string info = hdAc.GenerateMaHoaDonDAL();
            return info;
        }
        public string themhdBLL(HoaDonDTO hd)
        {
            string info = hdAc.themhdDAL(hd);
            return info;
        }

        public string xoaHdBLL(string mhd)
        {
            string info = hdAc.xoaHdDAL(mhd);
            return info;
        }

        public string updateHdBLL(HoaDonDTO hd)
        {
            string info = hdAc.updateHdDAL(hd);
            return info;
        }

        public List<string> LoadMaHdBLL()
        {
            List<string> info = hdAc.LoadMaHdDAL();
            return info;
        }

        public string tongTienHdBLL(string mhd)
        {
            string info = hdAc.tongTienHdDAL(mhd);
            if (string.IsNullOrEmpty(info))  
            {
                info = "0";
            }
            return info;
        }
    }
}
