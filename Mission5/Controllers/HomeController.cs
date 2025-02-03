using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission5.Models;

namespace Mission5.Controllers
{   //Home controler class
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // Action to go to the home/index page
        public IActionResult Index()
        {
            return View();
        }
        // Action to go to the PayMepage.
        public IActionResult PayMe()
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
