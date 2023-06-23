using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Web;
using WebApplicationCore.Models;
using WebApplicationCore.Services;

namespace WebApplicationCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index(StudentEditModel model)
        {
            var url = _configuration["API_URL:STUDENT_API_URL"] ?? "http://localhost:5243/api/Home/";

            var modelInput = new StudentGetlistInputRequest { Name = "Quan" };

            var jsonData = JsonConvert.SerializeObject(modelInput);

            var list = StudentServices.GetAllStudent(url, jsonData);

            return View();
        }

        public ActionResult ListProduct()
        {
            var url = _configuration["API_URL:STUDENT_API_PROD"] ?? "http://localhost:5243/api/Home/";


            var modelInput = new ProductGetlistInputRequest { MaSP = "" };

            var jsonData = JsonConvert.SerializeObject(modelInput);
            var list = ProductServices.GetListProduct(url, jsonData);
            return View(list);
        }

        public ActionResult CheckOut()
         {
            var list = new List<ShoppingCartModel>();
            try
            {
                var cookie = Request.Cookies["ShoppingCart"] != null ? Request.Cookies["ShoppingCart"] : string.Empty;
                if (cookie != null && !string.IsNullOrEmpty(cookie))
                {
                    list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ShoppingCartModel>>(HttpUtility.UrlDecode(cookie));
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return View(list);


        }


        public ActionResult StudentInfor(StudentEditModel model)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }


            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}