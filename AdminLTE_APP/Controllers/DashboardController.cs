using Microsoft.AspNetCore.Mvc;

namespace AdminLTE_APP.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
