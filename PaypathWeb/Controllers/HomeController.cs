using Microsoft.AspNetCore.Mvc;
using PaypathWeb.Models;
using System.Diagnostics;

namespace PaypathWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult SubmitNewsletter(string email)
        //{
        //    if (email != null)
        //    {
        //        Newsletter newsletter = new Newsletter()
        //        {
        //            Email = email
        //        };
        //        ViewBag.success = "Subscription Successful...!";
        //        return RedirectToAction("Index", "Home");
        //    }
        //    return RedirectToAction("Index", "Home");
        //}


        //Through AJAX
        [HttpPost]
        public IActionResult SubmitNewsletter(string email)
        {
            if (email != null)
            {
                Newsletter newsletter = new Newsletter()
                {
                    Email = email
                };
                return Json(new { status = true, message = "Subscribed Successfully...!" });
            }
            return Json(new { status = false, message = "Not Subscribed. An Error Occur...!" });
        }
    }
}
