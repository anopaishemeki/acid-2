using Microsoft.AspNetCore.Mvc;

namespace PaypathWeb.Controllers
{
    public class SettingController : Controller
    {
        private readonly ILogger<SettingController> _logger;

        public SettingController(ILogger<SettingController> logger)
        {
            _logger = logger;
        }

        public IActionResult NotFound()
        {
            return View();
        }
        public IActionResult ComingSoon()
        {
            return View();
        }
    }
}
