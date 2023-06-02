using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.DataAccess.Entities;

namespace UnitOfWork.DataAccess.DbContext
{
    public class MyShopUnitOfWorkDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MyShopUnitOfWorkDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder) { base.OnModelCreating(builder); }
        public DbSet<SANPHAM>? sanpham { get; set; }
        public DbSet<HOADON>? hoadon { get; set; }
        public DbSet<NHANVIEN>? nhanvien { get; set; }
    }
}
