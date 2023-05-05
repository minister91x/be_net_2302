using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BE_NET_2302.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public JsonResult Account_Login(string userName, string password)
        {
            var UserId = 1;
            // vào database để check userName và password
            Session.Add("UserLogin", UserId);
            return Json("", JsonRequestBehavior.AllowGet);
        }

        public ActionResult LogOut()
        {
            Session.RemoveAll();
            Session.Abandon();
            return RedirectToAction("Login", "Account");
        }
    }
}