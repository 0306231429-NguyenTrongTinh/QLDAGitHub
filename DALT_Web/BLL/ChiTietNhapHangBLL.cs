using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Text.RegularExpressions;
namespace BLL
{
    public class ChiTietNhapHangBLL
    {
        ChiTietNhapHangAccess cnhA = new ChiTietNhapHangAccess();

        public string kiemTraSpCthdBLL(string mpn, string msp)
        {
            string info = cnhA.kiemTraSpCthdDAL(mpn,msp);
            return info;
        }

        

        public float kiemTraThanhTienCtnhBLL(string mpn, string msp)
        {
            float info = cnhA.kiemTraThanhTienCtnhDAL(mpn, msp);
            return info;
        }

        public string updCtnh_NH_BLL(string mpn)
        {
            string info = cnhA.updCtnh_NH_DAL(mpn);
            return info;
        }

        public string updateCtnhBLL(ChiTietNhapHangDTO ctnh)
        {
            string info = cnhA.updateCtnhDAL(ctnh);
            return info;
        }

        public string themCtnhBLL(ChiTietNhapHangDTO ctnh)
        {
            string info = cnhA.themCtnhDAL(ctnh);
            return info;
        }

        public List<ChiTietNhapHangDTO> loadCthdBLL(string value)
        {
            List<ChiTietNhapHangDTO> info = cnhA.loadCthdDAL(value);
            return info;
        }

        public string xoaCtnhBLL(string mnh)
        {
            string info = cnhA.xoaCtnhDAL(mnh);
            return info;
        }

        public string xoaRowCtnhBLL(string mapn, string maSP)
        {
            string info = cnhA.xoaRowCtnhDAL(mapn, maSP);
            return info;
        }

        public List<string> LoadMaNcc_MaSpBLL(string mancc)
        {
            List<string> info = cnhA.LoadMaNcc_MaSpDAL( mancc);
            return info;
        }


        public string LoadMaPn_MaNccBLL(string mpn)
        {
            string info = cnhA.LoadMaPn_MaNccDAL(mpn);
            return info;
        }


        public List<KhoHangDTO> loadKhoHangTheoMaSP_BLL(string maSanPham)
        {
            List<KhoHangDTO> info = cnhA.loadKhoHangTheoMaSP_DAL(maSanPham);
            return info;
        }

        public string xoaCtnh_maspBLL(string msp)
        {
            string info = cnhA.xoaCtnh_maspDAL(msp);
            return info;
        }

        public string updCtnh_xntt_BLL(string mpn)
        {
            string info = cnhA.updCtnh_xntt_DAL(mpn);
            return info;
        }

        public float kiemTraGiaNhapCtnhBLL(string msp)
        {
            float info = cnhA.kiemTraGiaNhapCtnhDAL(msp);
            return info;
        }

        public string kiemTraTTspCthdBLL(string mpn)
        {
            string info = cnhA.kiemTraTTspCthdDAL(mpn);
            return info;
        }
    }
}
