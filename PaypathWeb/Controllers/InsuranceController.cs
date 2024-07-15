using Microsoft.AspNetCore.Mvc;

namespace PaypathWeb.Controllers
{
    public class InsuranceController : Controller
    {
        private readonly ILogger<InsuranceController> _logger;

        public InsuranceController(ILogger<InsuranceController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
