using Microsoft.AspNetCore.Mvc;
using PaypathWeb.Models;

namespace PaypathWeb.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Create(ContactForm contact)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        TempData["success"] = "Form Submitted Successfully...!";
        //        return RedirectToAction("Index","Contact");
        //    }
        //    return RedirectToAction("Index", "Contact");
        //}

        //Through AJAX
        [HttpPost]
        public IActionResult Create(string name, string email, string phoneNo, string subject, string message)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(phoneNo) && !string.IsNullOrEmpty(subject) && !string.IsNullOrEmpty(message))
            {
                ContactForm contactForm = new ContactForm()
                {
                    Name = name,
                    Email = email,
                    PhoneNo = phoneNo,
                    Subject = subject,
                    Message = message
                };
                TempData["success"] = "Form Submitted Successfully...!";
                return Json(new { status = true, message = "Form Submitted Successfully...!" });
            }
            return Json(new { status = false, message = "Form Not Submitted. An Error Occur...!" });
        }
    }
}
