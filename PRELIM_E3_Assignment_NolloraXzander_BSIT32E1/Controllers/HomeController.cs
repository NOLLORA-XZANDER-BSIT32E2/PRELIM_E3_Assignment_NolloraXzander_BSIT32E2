using Microsoft.AspNetCore.Mvc;
using PRELIM_E3_Assignment_NolloraXzander_BSIT32E1.Models;
using System.Diagnostics;

namespace PRELIM_E3_Assignment_NolloraXzander_BSIT32E1.Controllers
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
            var infoViewModel = new Info
            {
                Name = "Xzander James F. Nollora",
                Course = "BSIT",
                Section = "32E2"
            };

            return View(infoViewModel);
        }
        public IActionResult Schedule()
        {
            return View();
        }
    }
}
