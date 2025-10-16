using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    
    public class NhapHangBLL
    {
        NhapHangAccess nhA = new NhapHangAccess();

        public List<NhapHangDTO> loadDsNhapHangBLL()
        {
            List<NhapHangDTO> info = nhA.loadDsNhapHangDAL();
            return info;
        }

        public string GenerateMaNhapHangBLL()
        {
            string info = nhA.GenerateMaNhapHangDAL();
            return info;
        }
        public string themPnDAL(NhapHangDTO pn)
        {
            string info = nhA.themPnDAL(pn);
            return info;
        }

        public string xoaPnDAL(string mpn)
        {
            string info = nhA.xoaPnDAL(mpn);
            return info;
        }

        public string updatePnBLL(NhapHangDTO pn)
        {
            string info = nhA.updatePnDAL(pn);
            return info;
        }
        public List<NhapHangDTO> LoadSearchPnBLL(string tt, string value)
        {
            List<NhapHangDTO> info = nhA.LoadSearchPnDAL(tt, value);
            return info;
        }

        public string capNhatTrangThaiBLL(string tt, string mpn)
        {
            string info = nhA.capNhatTrangThaiDAL(tt, mpn);
            return info;
        }

        public List<string> LoadMaPnBLL()
        {
            List<string> info = nhA.LoadMaPnDAL();
            return info;
        }

        public string kiemTraiTonTaiPnBLL(NhapHangDTO pn)
        {
            string info = nhA.kiemTraiTonTaiPnDAL(pn);
            return info;
        }
    }
}
