using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new List<ProductModels>();
            for (int i = 0; i < 10; i++)
            {
                model.Add(new ProductModels { Id = i, Name = "Điện thoại số " + i });
            }
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //Kiểm tra quyền người 

            return RedirectToAction("Login", "Home");
        }


        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Detail(int? id)
        {
            ViewBag.ID = id;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}