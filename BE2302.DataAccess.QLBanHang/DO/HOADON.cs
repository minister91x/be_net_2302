using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE2302.DataAccess.QLBanHang.DO
{
    internal class HOADON
    {
        [Key]
        public int MaHD { get; set; }
        public string? MaKH { get; set; }
        public string? MaNV { get; set; }
        public DateTime NgayLapHD { get; set; }
        public DateTime NgayNhanHang { get; set; }

    }
}
