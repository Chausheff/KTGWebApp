namespace KTGWebApp.Controllers
{
    using KTGWebApp.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Diagnostics;

    public class AboutUsController : Controller
    {
        private readonly ILogger<AboutUsController> _logger;

        public AboutUsController(ILogger<AboutUsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View("AboutUs");
        }
    }
}

