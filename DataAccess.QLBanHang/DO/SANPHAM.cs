using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE2302.DataAccess.QLBanHang.DO
{
    public class SANPHAM
    {
        [Key]
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DonViTinh { get; set; }
        public int DonGia { get; set; }

    }
}
