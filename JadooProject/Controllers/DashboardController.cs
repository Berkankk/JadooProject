using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
