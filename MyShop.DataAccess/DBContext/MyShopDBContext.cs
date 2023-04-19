using MyShop.DataAccess.DO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.DBContext
{
    public class MyShopDBContext: DbContext
    {
        public MyShopDBContext() : base("ManagerProduct")
        {
            var initializer = new MigrateDatabaseToLatestVersion<MyShopDBContext, Migrations.Configuration>();
            Database.SetInitializer(initializer);
        }

        public virtual DbSet<SanPham> sampham { get; set; }
        public virtual DbSet<NhanVien> nhanvien { get; set; }
        public virtual DbSet<HoaDon> hoadon { get; set; }
        public virtual DbSet<ChiTietHoaDon> chitiethoadon { get; set; }

    }
}
