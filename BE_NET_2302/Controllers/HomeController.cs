using AutoMapper;
using BE_NET_2302.ADONET;
using BE_NET_2302.Entities;
using BE_NET_2302.Models;
using BE2302.DataAccess.QLBanHang.DAL;
using BE2302.DataAccess.QLBanHang.DO;
using DataAccess.QLBanHang.DAL;
using DataAccess.QLBanHang.DO;
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
                var lst_adoNet = repos_adoNet.Nhanvien_DanhSach();

            }
            catch (Exception ex)
            {

                throw;
            }
            return View();
        }


        [HttpGet]
        [HttpPost]
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

        public ActionResult PartialViewDemo()
        {
            var list_nhanvien = new List<NHANVIEN>();
            try
            {
                var dbConect = new DataAccess.QLBanHang.QuanlyNhanVienDBContext();
                var repos = new NhanVienRepository();
                var repos_adoNet = new NhanVienRepositoryADO_NET();
                list_nhanvien = repos_adoNet.Nhanvien_DanhSach();
            }
            catch (Exception ex)
            {

                throw;
            }

            return PartialView("~/Views/PartialViews/PartialViewDemo.cshtml", list_nhanvien);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult NhanVien_Insert(EmployeeRegisterModels inputdata)
        {
            var model = new ResponseData();
            try
            {
                if (!ModelState.IsValid)
                {

                }

                // kiểm tra về mặt dữ liệu
                if (inputdata == null
                    || string.IsNullOrEmpty(inputdata.TenNV))
                {
                    model.ResponseCode = -99;
                    model.ResponseMessenger = "Thêm mới nhân viên thất bại";
                    return Json(model, JsonRequestBehavior.AllowGet);
                }

                // Kiểm tra bảo mật

                if (!CheckXSSInput(inputdata.TenNV))
                {
                    model.ResponseCode = -999;
                    model.ResponseMessenger = "Dữ liệu không hợp lệ";
                    return Json(model, JsonRequestBehavior.AllowGet);
                }




                var dbConect = new DataAccess.QLBanHang.QuanlyNhanVienDBContext();
                var repos = new NhanVienRepository();


                var nhanvien_insertReq = new NHANVIEN
                {
                    MaNV = inputdata.MaNV,
                    TenNV = inputdata.TenNV,
                    DiaChi = inputdata.DiaChi,
                    NgaySinh = DateTime.Now
                };

                var result = repos.Nhanvien_Themmoi(nhanvien_insertReq);
                if (result < 0)
                {
                    model.ResponseCode = -1;
                    model.ResponseMessenger = "Thêm mới nhân viên thất bại";
                    return Json(model, JsonRequestBehavior.AllowGet);
                }

                model.ResponseCode = 1;
                model.ResponseMessenger = "Thêm mới nhân viên thành công";
                return Json(model, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        [HttpPost]
        public JsonResult NhanVien_Update(string MaNV, string TenNV, string DiaChi)
        {
            try
            {
                var model = new ResponseData();
                var dbConect = new DataAccess.QLBanHang.QuanlyNhanVienDBContext();
                var repos = new NhanVienRepository();
                var nhanvien_insertReq = new NHANVIEN
                {
                    MaNV = MaNV,
                    TenNV = TenNV,
                    DiaChi = DiaChi,
                    NgaySinh = DateTime.Now
                };

                var result = repos.Nhanvien_update(nhanvien_insertReq);
                if (result < 0)
                {
                    model.ResponseCode = -1;
                    model.ResponseMessenger = "Thêm mới nhân viên thất bại";
                    return Json(model, JsonRequestBehavior.AllowGet);
                }

                model.ResponseCode = 1;
                model.ResponseMessenger = "Thêm mới nhân viên thành công";
                return Json(model, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public ActionResult Login() { return View(); }

        public static bool CheckXSSInput(string input)
        {
            try
            {
                var listdangerousString = new List<string> { "<applet", "<body", "<embed", "<frame", "<script", "<frameset", "<html", "<iframe", "<img", "<style", "<layer", "<link", "<ilayer", "<meta", "<object", "<h", "<input", "<a", "&lt", "&gt" };
                if (string.IsNullOrEmpty(input)) return false;
                foreach (var dangerous in listdangerousString)
                {
                    if (input.Trim().ToLower().IndexOf(dangerous) >= 0) return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}