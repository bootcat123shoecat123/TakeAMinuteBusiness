using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TakeAMinuteBusiness.Models;

namespace TakeAMinuteBusiness.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Pie()
        {
            return View();

        }
        public ActionResult GameDatabase()
        {

            List<string> e = new List<string>();
            e.Add("www");
            e.Add("weqe");
            return View(e);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}