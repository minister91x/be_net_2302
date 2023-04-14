using BE2302.DataAccess.QLBanHang.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE2302.DataAccess.QLBanHang.DAO
{
    public interface ISanPhamDAL
    {
        List<SANPHAM> SANPHAM_DanhSach();
    }
}
