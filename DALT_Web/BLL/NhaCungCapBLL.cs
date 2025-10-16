using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class NhaCungCapBLL
    {
        NhaCungCapAccess nccB = new NhaCungCapAccess();
        public List<string> LoadMaNccBLL()
        {
            List<string> info = nccB.LoadMaNccDAL();
            return info;
        }

        public List<NhaCungCapDTO> loadNccBLL()
        {
            List<NhaCungCapDTO> info = nccB.loadNccDAL();
            return info;
        }

        public string GenerateMaNccBLL()
        {
            string info = nccB.GenerateMaNccDAL();
            return info;
        }

        public string themNccBLL(NhaCungCapDTO ncc)
        {
            string info = nccB.themNccDAL(ncc);
            return info;
        }

        public string xoaNccBLL(string mncc)
        {
            string info = nccB.xoaNccDAL(mncc);
            return info;
        }

        public string updateMaNccBLL(NhaCungCapDTO ncc)
        {
            string info = nccB.updateMaNccDAL(ncc);
            return info;
        }

        public List<NhaCungCapDTO> LoadSearchNccBLL(string tt, string value)
        {
            List<NhaCungCapDTO> info = nccB.LoadSearchNccDAL(tt, value);
            return info;
        }

        public List<string> LoadThongTinNccDAL(string ncc)
        {
            List<string> info = nccB.LoadThongTinNccDAL(ncc);
            return info;
        }
    }
}
