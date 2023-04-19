using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.DO
{
    public class NhanVien
    {
        [Key]
        public string? MaNV { get; set; }
        public string? HoNV { get; set; }
        public string? TenNV { get; set; }
        public int GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public string? DienThoai { get; set; }

    }
}
