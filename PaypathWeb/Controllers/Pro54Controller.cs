using Microsoft.AspNetCore.Mvc;

namespace PaypathWeb.Controllers
{
    public class Pro54Controller : Controller
    {
        private readonly ILogger<Pro54Controller> _logger;

        public Pro54Controller(ILogger<Pro54Controller> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
