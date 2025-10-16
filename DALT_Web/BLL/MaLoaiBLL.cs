using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class MaLoaiBLL
    {
        MaLoaiAccess mlA = new MaLoaiAccess();
        public List<string> LoadMaLoaiBLL()
        {
            List<string> info = mlA.LoadMaLoaiDAL();
            return info;
        }

        public string LoadTenMaLoaiBLL(string ml)
        {
            string info = mlA.LoadTenMaLoaiDAL(ml);
            return info;
        }
    }
}
