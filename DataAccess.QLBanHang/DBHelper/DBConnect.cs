using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.QLBanHang.DBHelper
{
    public static class DBConnect
    {
        public static string connString = "data source=DESKTOP-IFRSV3F;initial catalog=ManagerProduct;user id=sa;password=123456";
        public static SqlConnection GetSqlConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                return conn;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
