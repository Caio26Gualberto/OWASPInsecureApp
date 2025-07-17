using Microsoft.AspNetCore.Mvc;
using OWASPInsecureApp.Data;

namespace OWASPInsecureApp.Controllers
{
    public class ProfileController : Controller
    {
        private readonly OWASPInsecureAppDbContext _appDbContext;
        private const int UserLoggedId = 1;

        public ProfileController(OWASPInsecureAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Details(int id)
        {
            var user = _appDbContext.Users.Find(id);
            if (user == null)
                return NotFound();

            ViewBag.IsIdor = id != UserLoggedId;

            return View(user);
        }
    }
}
