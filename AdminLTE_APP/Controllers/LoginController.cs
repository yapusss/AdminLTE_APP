using Microsoft.AspNetCore.Mvc;

namespace AdminLTE_APP.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index(string error = null)
        {
            ViewBag.Error = error;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            if (username == "admin" && password == "Admin")
            {
                // Redirect to Dashboard if login is successful
                return RedirectToAction("Index", "Dashboard");
            }
            // Show error and stay on login page if login fails
            ViewBag.Error = "Username or password is incorrect.";
            return View();
        }
    }
}
