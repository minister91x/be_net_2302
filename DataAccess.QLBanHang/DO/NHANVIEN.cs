using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE2302.DataAccess.QLBanHang.DO
{
    public class NHANVIEN
    {
    
    [Key]
    public string MaNV { get; set; }
    public string HoNV { get; set; }
    public string TenNV { get; set; }
    public bool GioiTinh { get; set; }
    public DateTime NgaySinh { get; set; }
    public string DiaChi { get; set; }
    public string DienThoai { get; set; }

        //DAO: Data Accessc Object 
        //DO : Data Object
        // DAL : data Access Layer
}
}
