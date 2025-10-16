using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class LoaiSanPhamBLL
    {
        LoaiSanPhamAccess lspA = new LoaiSanPhamAccess();

        public List<LoaiSanPhamDTO> LoadLspBLL()
        {
            List<LoaiSanPhamDTO> info = lspA.LoadLspDAL();
            return info;
        }

        public string GenerateMaLspBLL()
        {
            string info = lspA.GenerateMaLspDAL();
            return info;
        }
        public string themLspBLL(LoaiSanPhamDTO lsp)
        {
            string info = lspA.themLspDAL(lsp);
            return info;
        }

        public string xoaLspBLL(string mlsp)
        {
            string info = lspA.xoaLspDAL(mlsp);
            return info;
        }

        public string updateMaLspBLL(LoaiSanPhamDTO lsp)
        {
            string info = lspA.updateMaLspDAL(lsp);
            return info;
        }

        public List<LoaiSanPhamDTO> LoadSearchLspBLL(string tt, string value)
        {
            List<LoaiSanPhamDTO> info = lspA.LoadSearchLspDAL(tt, value);
            return info;
        }
    }
}
