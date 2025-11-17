namespace KTGWebApp.Controllers
{
    using KTGWebApp.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Diagnostics;

    public class SendRequestController : Controller
    {
        private readonly ILogger<SendRequestController> _logger;

        public SendRequestController(ILogger<SendRequestController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendRequest()
        {
            return View("SendRequest");
        }
    }
}

