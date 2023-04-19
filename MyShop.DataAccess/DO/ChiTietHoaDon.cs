using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.DO
{
    public class ChiTietHoaDon
    {
        [Key]
        public int VoiceID { get; set; }
        public HoaDon? MaHD { get; set; }
        public SanPham? MaSP { get; set; }
        public int SoLuong { get; set; }

    }
}
