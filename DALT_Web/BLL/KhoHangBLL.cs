using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class KhoHangBLL
    {
        KhoHangAccess khA = new KhoHangAccess();
        public List<KhoHangDTO> loadDsKhoHangBLL()
        {
            List<KhoHangDTO> info = khA.loadDsKhoHangDAL();
            return info;
        }
        public string updateKhoHangBLL(KhoHangDTO kh)
        {
            string info = khA.updateKhoHangDAL(kh);
            return info;
        }

        public string xoaKhBLL(string msp)
        {
            string info = khA.xoaKhDAL(msp);
            return info;
        }
    }
}
