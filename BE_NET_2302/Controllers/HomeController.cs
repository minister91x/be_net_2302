using BE_NET_2302.ADONET;
using BE_NET_2302.Entities;
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
                var context = new ProductDbContext();
                //var product = new Product();
                //product.Name = "Iphone 15";
                //product.Price = 100000000;
                //product.Quantity = 100;

                //var order = new Orders { OrderId = "HD_02", ProductId = 1, Quantity = 10,
                //    OrderTotal = 1000,
                //    OrderDate = DateTime.Now
                //};

                //context.product.Add(product);
                //context.order.Add(order);
                //var result = context.SaveChanges();

                ///var listproduct = context.product.ToList();
                ///
                var productManager = new ProductManager();
                var list = productManager.GetProducts();

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