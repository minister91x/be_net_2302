using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.DO
{
    public class SanPham
    {
        [Key]
        public string? MaSP { get; set; }
        public string? TenSP { get; set; }
        public string? DonViTinh { get; set; }
        public int DonGia { get; set; }

    }
}
