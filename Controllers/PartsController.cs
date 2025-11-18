namespace KTGWebApp.Controllers
{
    using KTGWebApp.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Diagnostics;

    public class PartsController : Controller
    {
        private readonly ILogger<PartsController> _logger;

        public PartsController(ILogger<PartsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Parts()
        {
            return View("Parts");
        }
    }
}

