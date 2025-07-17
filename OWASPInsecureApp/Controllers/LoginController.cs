using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using OWASPInsecureApp.Data;
using OWASPInsecureApp.Models;

namespace OWASPInsecureApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly OWASPInsecureAppDbContext _db;
        public LoginController(IConfiguration configuration, OWASPInsecureAppDbContext appDbContext)
        {
            _configuration = configuration;
            _db = appDbContext;
        }
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var connString = _configuration.GetConnectionString("DefaultConnection") ?? "Data Source=DESKTOP-5TU91TS\\SQLEXPRESS;Initial Catalog=OWASPInsecureApp;trusted_connection=True;TrustServerCertificate=True;";
            using var connection = new SqlConnection(connString);
            connection.Open();

            var cmd = connection.CreateCommand();

            // ⚠️ Here is the VULNERABILITY (SQL INJECTION):
            cmd.CommandText = $"SELECT * FROM Users WHERE Username = '{username}' AND Password = '{password}'";
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
                ViewBag.Message = "Login successful!";
            else
                ViewBag.Message = "Invalid username or password.";

            return View();
        }

        public IActionResult Register() => View();
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Register(string username, string password)
        {
            var user = new User { Username = username, Password = password }; // ❌ No encryption
            _db.Users.Add(user);
            _db.SaveChanges();
            return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                TempData["Message"] = "Logged in!";
                return RedirectToAction("Welcome");
            }

            TempData["Message"] = "Invalid credentials.";
            return RedirectToAction("Login");
        }

        public IActionResult Welcome() => View();

    }
}
