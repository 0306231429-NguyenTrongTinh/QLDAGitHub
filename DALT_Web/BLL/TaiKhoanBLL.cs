using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanAccess TkAccess = new TaiKhoanAccess();
        public List<string> checkLoginBLL(TaiKhoanDTO tk) // (1)
        {
            List<string> info = new List<string>();
            if (tk.TenDangNhap == "Your usename")
            {
                info.Add("rq_tk");
                return info;
            }
            if (tk.MatKhau == "Your password")
            {
                info.Add("rq_pass");
                return info;
            }
            info = TkAccess.checkLoginDAL(tk);
            return info;
        }

        public string updateMkBLL(string user, string mkCu, string mkMoi)
        {
            string info = TkAccess.updateMkDAL(user, mkCu, mkMoi);
            return info;
        }

        public string ktTaiKhoanBLL(string user)
        {
            string info = TkAccess.ktTaiKhoanDAL(user);
            return info;
        }


        public string themTkBLL(TaiKhoanDTO tk)
        {
            string info = TkAccess.themTkDAL(tk);
            return info;
        }

        public List<TaiKhoanDTO> loadDsTaiKhoanBLL()
        {
            List<TaiKhoanDTO> info = TkAccess.loadDsTaiKhoanDAL();
            return info;
        }

        public string xoaTkBLL(string mnv)
        {
            string info = TkAccess.xoaTkDAL(mnv);
            return info;
        }

        public string updateTkBLL(TaiKhoanDTO tk)
        {
            string info = TkAccess.updateTkDAL(tk);
            return info;
        }

        public string GenerateMaNhanVienBLL()
        {
            string info = TkAccess.GenerateMaNhanVienDAL();
            return info;
        }

        public string capNhatTrangThaiDAL(string quyen, string mtk)
        {
            string info = TkAccess.capNhatTrangThaiDAL(quyen,mtk);
            return info;
        }
    }


}
