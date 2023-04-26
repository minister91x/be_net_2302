using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BE_NET_2302.Models
{
    public class ViewsModels
    {
        public string MaNV { get; set; }
        public string HoNV { get; set; }
        public string TenNV { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

        public int Point { get; set; }
    }
}