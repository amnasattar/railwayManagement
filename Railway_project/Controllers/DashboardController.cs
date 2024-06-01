using Microsoft.AspNetCore.Mvc;

namespace Railway_project.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Reservation()
        {
            return View();
        }
    }
}
