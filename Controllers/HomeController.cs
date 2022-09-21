using ContosoConfApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ContosoConfApp.Services;

namespace ContosoConfApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SessionService _service;

        public HomeController(
            SessionService service,
            ILogger<HomeController> logger)
        {
            _logger = logger;
            _service = service;
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
            var viewModel = _service.GetSessions();
            return View(viewModel);
        }

        public IActionResult SessionDetails(int id)
        {
            var viewModel = _service.GetSessionDetails(id);
            return View(viewModel);
        }
        
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}