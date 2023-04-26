using BE2302.DataAccess.QLBanHang.DO;
using DataAccess.QLBanHang.DO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.QLBanHang.DBHelper
{
    public class NhanVienRepositoryDbHelper
    {
        public List<NHANVIEN> Nhanvien_GetList()
        {
            var list = new List<NHANVIEN>();
            //Bước 1: Tạo connect đến database 
            var connect = DBConnect.GetSqlConnection();
            //Bước 2: Sử dụng SqlCommand để thao tác với database 
            //var cmd = new SqlCommand("SELECT * FROM NHANVIEN", connect);
            //cmd.CommandType = System.Data.CommandType.Text;

            var cmd2 = new SqlCommand("SP_NhanVien_GetAll", connect);
            cmd2.CommandType = System.Data.CommandType.StoredProcedure;

            //bước 3: Dùng SQLREADER dể hứng dữ liệu
            var reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                var nhanvien = new NHANVIEN();
                nhanvien.MaNV = reader["MaNV"] != null ? reader["MaNV"].ToString() : "";
                nhanvien.TenNV = reader["TenNV"] != null ? reader["TenNV"].ToString() : "";
                list.Add(nhanvien);
            }
            connect.Close();

            return list;
        }

        public int NhanVien_Insert(NHANVIEN nhanvien)
        {

            //Bước 1: Tạo connect đến database 
            var connect = DBConnect.GetSqlConnection();
            //Bước 2: Sử dụng SqlCommand để thao tác với database 
            //var cmd = new SqlCommand("SELECT * FROM NHANVIEN", connect);
            //cmd.CommandType = System.Data.CommandType.Text;

            var cmd2 = new SqlCommand("SP_NhanVien_Insert", connect);
            cmd2.CommandType = System.Data.CommandType.StoredProcedure;

            cmd2.Parameters.AddWithValue("@_MaNV", nhanvien.MaNV);
            cmd2.Parameters.AddWithValue("@_HoNV", nhanvien.HoNV);


            return cmd2.ExecuteNonQuery();
        }
    }
}
