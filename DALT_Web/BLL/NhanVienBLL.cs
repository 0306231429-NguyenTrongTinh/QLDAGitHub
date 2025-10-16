using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienAccess nvA = new NhanVienAccess();
        public List<string> LoadMaNvBLL()
        {
            List<string> info = nvA.LoadMaNvDAL();
            return info;
        }

        public string GenerateMaNhanVienBLL()
        {
            string info = nvA.GenerateMaNhanVienDAL();
            return info;
        }

        public string themNvBLL(NhanVienDTO nv)
        {
            string info = nvA.themNvDAL(nv);
            return info;
        }

        public List<string> LoadMaNvTkBLL()
        {
            List<string> info = nvA.LoadMaNvTkDAL();
            return info;
        }

        public string LoadQuyenNvBLL(string mnv)
        {
            string info = nvA.LoadQuyenNvDAL(mnv);
            return info;
        }

        public List<NhanVienDTO> loadDsNhanVienBLL()
        {
            List<NhanVienDTO> info = nvA.loadDsNhanVienDAL();
            return info;
        }

        public List<NhanVienDTO> LoadSearchNvBLL(string tt, string value)
        {
            List<NhanVienDTO> info = nvA.LoadSearchNvDAL(tt, value);
            return info;
        }

        public string xoaNvBLL(string mnv)
        {
            string info = nvA.xoaNvDAL(mnv);
            return info;
        }

        public string updateNvBLL(NhanVienDTO nv)
        {
            string info = nvA.updateNvDAL(nv);
            return info;
        }

        public string ktSDTNvBLL(string sdt)
        {
            string info = nvA.ktSDTNvDAL(sdt);
            return info;
        }

        public List<string> LoadThongTinNvDAL(string manv)
        {
            List<string> info = nvA.LoadThongTinNvDAL(manv);
            return info;
        }
    }
}
