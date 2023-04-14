using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE2302.DataAccess.QLBanHang.DO
{
    public class CHITIETHD
    {
        [Key]
        public int ID { get; set; }
        public HOADON MaHD { get; set; }
        public SANPHAM MaSP { get; set; }
        public int SoLuong { get; set; }

    }
}
