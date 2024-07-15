using Microsoft.AspNetCore.Mvc;

namespace PaypathWeb.Controllers
{
    public class HealthcareController : Controller
    {
        private readonly ILogger<HealthcareController> _logger;

        public HealthcareController(ILogger<HealthcareController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
