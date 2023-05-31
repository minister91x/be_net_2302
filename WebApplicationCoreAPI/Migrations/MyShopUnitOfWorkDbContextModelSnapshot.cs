﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnitOfWork.DataAccess.DbContext;

#nullable disable

namespace WebApplicationCoreAPI.Migrations
{
    [DbContext(typeof(MyShopUnitOfWorkDbContext))]
    partial class MyShopUnitOfWorkDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UnitOfWork.DataAccess.Entities.HOADON", b =>
                {
                    b.Property<int>("MaHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHD"));

                    b.Property<string>("MaKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayLapHD")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayNhanHang")
                        .HasColumnType("datetime2");

                    b.HasKey("MaHD");

                    b.ToTable("hoadon");
                });

            modelBuilder.Entity("UnitOfWork.DataAccess.Entities.NHANVIEN", b =>
                {
                    b.Property<string>("MaNV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("HoNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNV");

                    b.ToTable("nhanvien");
                });

            modelBuilder.Entity("UnitOfWork.DataAccess.Entities.SANPHAM", b =>
                {
                    b.Property<string>("MaSP")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<string>("DonViTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSP");

                    b.ToTable("sanpham");
                });
#pragma warning restore 612, 618
        }
    }
}