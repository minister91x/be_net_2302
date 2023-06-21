using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationCore.Models;

namespace WebApplicationCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(StudentEditModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View();
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