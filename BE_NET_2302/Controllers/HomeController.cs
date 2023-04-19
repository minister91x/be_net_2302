using BE_NET_2302.ADONET;
using BE_NET_2302.Entities;
using BE2302.DataAccess.QLBanHang.DAL;
using BE2302.DataAccess.QLBanHang.DO;
using DataAccess.QLBanHang.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BE_NET_2302.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {

                var dbConect = new DataAccess.QLBanHang.QuanlyNhanVienDBContext();
                var repos = new NhanVienRepository();
                var repos_adoNet = new NhanVienRepositoryADO_NET();

                var nhanVien = new NHANVIEN();
                nhanVien.MaNV = Guid.NewGuid().ToString();
                nhanVien.TenNV = "Mr Quân 12";
                nhanVien.NgaySinh = DateTime.Now;
                nhanVien.DiaChi = "Hà Nội";
                //repos.Nhanvien_Themmoi(nhanVien);
                repos_adoNet.Nhanvien_Themmoi(nhanVien);

                var lst= dbConect.nhanvien.ToList();

               
                var lst_adoNet = repos_adoNet.Nhanvien_DanhSach();



            }
            catch (Exception ex)
            {

                throw;
            }
            return View();
        }

        public ActionResult About()
        {
            //Comment code
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}