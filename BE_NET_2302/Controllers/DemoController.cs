using BE2302.DataAccess.QLBanHang.DO;
using DataAccess.QLBanHang.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BE_NET_2302.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index(int? a)
        {
           
            return Json("", JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index1(List<NHANVIEN> nhanvien)
        {
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}