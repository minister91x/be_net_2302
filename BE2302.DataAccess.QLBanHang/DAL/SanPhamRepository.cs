using BE2302.DataAccess.QLBanHang.DAO;
using BE2302.DataAccess.QLBanHang.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE2302.DataAccess.QLBanHang.DAL
{
    public class SanPhamRepository : ISanPhamDAL
    {
        QuanlyNhanVienDBContext dbcontext = new QuanlyNhanVienDBContext();
        public List<SANPHAM> SANPHAM_DanhSach()
        {
            return dbcontext.sanpham.ToList();
        }

    }
}
