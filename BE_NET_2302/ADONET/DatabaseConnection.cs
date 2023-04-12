using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BE_NET_2302.ADONET
{
    public static class DatabaseConnection
    {
        static SqlConnection conn ;
       
        public static SqlConnection GetSqlConnection()
        {
             string connectionString = "data source=DESKTOP-IFRSV3F;initial catalog=ManagerProduct;user id=sa;password=123456;";
            conn = new SqlConnection(connectionString);
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
        }
    }
}