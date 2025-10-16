using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection connect()
        {
            string str = "Data Source=LAPTOP-SSIJJB8B;Initial Catalog=QL_STMN;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(str);
            return conn;
        }
    }
}
