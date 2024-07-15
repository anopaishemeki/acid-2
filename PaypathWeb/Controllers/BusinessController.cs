using Microsoft.AspNetCore.Mvc;

namespace PaypathWeb.Controllers
{
    public class BusinessController : Controller
    {
        private readonly ILogger<BusinessController> _logger;

        public BusinessController(ILogger<BusinessController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
