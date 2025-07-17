using Microsoft.AspNetCore.Mvc;

namespace OWASPInsecureApp.Controllers
{
    public class UnsafeRedirectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RedirectTo(string returnUrl)
        {
            return Redirect(returnUrl); // VULNERABILITY: no validation (Unvalidated Redirects and Forwards)
        }
    }
}
