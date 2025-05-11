using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
     class Modify
    {
        public Modify() 
        {

        }

        public List<TaiKhoan> TaiKhoans(String query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection()) 
            {
                sqlConnection.Open();

                sqlConnection.Close(); 
            }
            return taiKhoans;
        }

    }
}
