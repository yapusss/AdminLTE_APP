using Microsoft.AspNetCore.Mvc;

namespace AdminLTE_APP.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
