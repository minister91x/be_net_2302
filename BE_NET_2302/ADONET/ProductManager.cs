using BE_NET_2302.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BE_NET_2302.ADONET
{
    public class ProductManager
    {
        public List<Product> GetProducts()
        {
            var lisst = new List<Product>();

            // Bước 1: connect đến database 
            var sqlconnect = DatabaseConnection.GetSqlConnection();
            // Bước 2: Sử dụng SqlCommand để thao tác với database 
            var cmd = new SqlCommand("SELECT * FROM PRODUCTS", sqlconnect);
            cmd.CommandType = System.Data.CommandType.Text;
            //Bước 3: hứng dữ liệu từ databas trả về vào sqlreader 
            var reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                var product = new Product();
                product.ProductID = reader["ProductID"] != null ? Convert.ToInt32(reader["ProductID"].ToString()) : 0;
                product.Name = reader["Name"] != null ? reader["Name"].ToString() : "";
                lisst.Add(product);
            }
            return lisst;
        }
    }
}