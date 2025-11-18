namespace KTGWebApp.Controllers
{
    using KTGWebApp.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Diagnostics;

    public class CargoWagonsController : Controller
    {
        private readonly ILogger<CargoWagonsController> _logger;

        public CargoWagonsController(ILogger<CargoWagonsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

