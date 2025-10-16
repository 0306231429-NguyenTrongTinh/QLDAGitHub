using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangAccess khAc = new KhachHangAccess();
        public List<KhachHangDTO> loadKhachHangBLL()
        {
            List<KhachHangDTO> dsKhachHang = new List<KhachHangDTO>();
            dsKhachHang = khAc.loadKhachHangDAL();
            return dsKhachHang;
        }

        public List<string> LoadMaKHBLL()
        {
            List<string> info = new List<string>();
            info = khAc.LoadMaKHDAL();
            return info;
        }

        public List<string> LoadThongTinKHBLL(KhachHangDTO kh)
        {
            List<string> dsKhachHang = new List<string>();
            dsKhachHang = khAc.LoadThongTinKHDAL(kh);
            return dsKhachHang;
        }

        public string themKhBLL(KhachHangDTO kh)
        {
            string info = khAc.themKhDAL(kh);
            return info;
        }

        public string xoaKhBLL(string mkh)
        {
            string info = khAc.xoaKhDAL(mkh);
            return info;
        }

        public string updateKhBLL(KhachHangDTO kh)
        {
            string info = khAc.updateKhDAL(kh);
            return info;
        }

        public string GenerateMaKhBLL()
        {
            string info = khAc.GenerateMaKhDAL();
            return info;
        }

        public string ktSDTKhBLL(string sdt)
        {
            string kq = khAc.ktSDTKhDAL(sdt);
            return kq;
        }

        public List<KhachHangDTO> LoadSearchKhBLL(string tt, string value)
        {
            List<KhachHangDTO> info = khAc.LoadSearchKhDAL(tt, value);
            return info;
        }

        public string updateDTLKhBLL(int dtl, string mkh)
        {
            string kq = khAc.updateDTLKhDAL(dtl, mkh);
            return kq;
        }

        public int loadDTLKhachHangBLL(string mkh)
        {
            int dtl = khAc.loadDTLKhachHangDAL(mkh);
            return dtl;
        }
    }
}
