using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace OWASPInsecureApp.Controllers
{
    public class DiagnosticsController : Controller
    {
        [HttpGet]
        public IActionResult Ping() => View();

        [HttpPost]
        public IActionResult Ping(string ipAddress)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C ping -n 2 {ipAddress}", // For WINDOWS
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            var output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            ViewBag.Result = output;
            return View();
        }

    }
}
