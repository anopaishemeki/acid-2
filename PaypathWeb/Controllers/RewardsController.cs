
using Microsoft.AspNetCore.Mvc;

namespace PaypathWeb.Controllers
{
    public class RewardsController : Controller
    {
        private readonly ILogger<RewardsController> _logger;

        public RewardsController(ILogger<RewardsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
