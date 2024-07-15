using Microsoft.AspNetCore.Mvc;

namespace PaypathWeb.Controllers
{
    public class BankingController : Controller
    {
        private readonly ILogger<BankingController> _logger;

        public BankingController(ILogger<BankingController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
