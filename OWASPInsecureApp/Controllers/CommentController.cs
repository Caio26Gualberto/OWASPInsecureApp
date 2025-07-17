using Microsoft.AspNetCore.Mvc;
using OWASPInsecureApp.Data;
using OWASPInsecureApp.Models;

namespace OWASPInsecureApp.Controllers
{
    public class CommentController : Controller
    {
        private readonly OWASPInsecureAppDbContext _appDbContext;
        public CommentController(OWASPInsecureAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index() => View();

        [HttpPost]
        //From this insertion of an entity in the database we can save JS scripts in the table, when retrieving the script in the frontend it will be executed
        //To prevent XSS we can use the native Razon, it already has native XSS prevention,
        //we can use policies in the request headers to not apply script in the HTML, there are libraries among other options
        public IActionResult CreateComment(string text)
        {
            var comment = new Comment { Text = text };
            _appDbContext.Comments.Add(comment);
            _appDbContext.SaveChanges();
            return RedirectToAction("Comments");
        }

        public IActionResult Comments()
        {
            var comments = _appDbContext.Comments.ToList();
            return View(comments);
        }
    }
}
