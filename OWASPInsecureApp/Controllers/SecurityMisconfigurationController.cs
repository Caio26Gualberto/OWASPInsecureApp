using Microsoft.AspNetCore.Mvc;

namespace OWASPInsecureApp.Controllers
{
    public class SecurityMisconfigurationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
