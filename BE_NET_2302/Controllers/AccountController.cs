using BE_NET_2302.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        public JsonResult Account_Login(AccountAuthenRequestData requestData)
        {
            var returnData = new ReturnData();
            try
            {
                //userName=quannt&password=xyz
                var url = ConfigurationManager.AppSettings["API_URL"] ?? "http://localhost:5243/api/";
                var url_authen = url + "Auth/Authen";

                //dynamic authenData = new {
                //    userName = userName,
                //    password = password 
                //};

                //var jsonData = JsonConvert.SerializeObject(authenData);

                //var req = new AccountAuthenRequestData { UserName = userName, Password = password };

                var jsonData = JsonConvert.SerializeObject(requestData);

                var result = Common.SendPost_Authen(url_authen, jsonData);

                if (string.IsNullOrEmpty(result))
                {
                    returnData.ResponseCode = -1;
                    returnData.ResponseMessage = "Đăng nhập thất bại";
                    return Json(returnData, JsonRequestBehavior.AllowGet);
                }


                returnData.ResponseCode = 1;
                returnData.ResponseMessage = result;
                return Json(returnData, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                returnData.ResponseCode = -99;
                returnData.ResponseMessage = ex.Message;
                return Json(returnData, JsonRequestBehavior.AllowGet);
            }

        }

        public ActionResult LogOut()
        {
            Session.RemoveAll();
            Session.Abandon();
            return RedirectToAction("Login", "Account");
        }
    }
}