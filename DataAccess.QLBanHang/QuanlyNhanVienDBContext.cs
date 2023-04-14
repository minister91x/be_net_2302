using BE2302.DataAccess.QLBanHang.DO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.QLBanHang
{
    public class QuanlyNhanVienDBContext : DbContext
    {
        public QuanlyNhanVienDBContext() : base("ManagerProduct")
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<QuanlyNhanVienDBContext>());

            var initializer = new MigrateDatabaseToLatestVersion<QuanlyNhanVienDBContext, Migrations.Configuration>();
            Database.SetInitializer(initializer);
        }
        //  public virtual DbSet<Product> product { get; set; }
        //  public virtual DbSet<Orders> order { get; set; }
        public virtual DbSet<NHANVIEN> nhanvien { get; set; }
        public virtual DbSet<SANPHAM> sanpham { get; set; }
        public virtual DbSet<HOADON> hoadon { get; set; }
        public virtual DbSet<CHITIETHD> chitiethoadon { get; set; }
    }
}
