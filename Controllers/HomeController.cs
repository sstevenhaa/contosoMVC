using ContosoConfApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ContosoConfApp.Controllers
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
        public IActionResult Sessions()
        {
            return View();
        }
        public IActionResult MichaelGonzalez()
        {
            return View();
        }
        public IActionResult JordanWaite()
        {
            return View();
        }
        public IActionResult StevenHa()
        {
            return View();
        }
        public IActionResult TrevonNoble()
        {
            return View();
        }
        public IActionResult RabinGhaju()
        {
            return View();
        }
        public IActionResult ClayLeimgruber()
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