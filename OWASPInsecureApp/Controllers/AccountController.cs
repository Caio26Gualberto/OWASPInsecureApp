using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace OWASPInsecureApp.Controllers
{
    public class AccountController : Controller
    {
        private static string _currentEmail = "UserEmailFromYourWebsiste@eExample.com"; 

        public IActionResult Settings()
        {
            ViewBag.Email = _currentEmail;
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken] //This decorator prevents access from other websites (Counter: CSRF)
        public IActionResult ChangeEmail(string email)
        {
            _currentEmail = email;
            return RedirectToAction("Settings");
        }
    }
}
