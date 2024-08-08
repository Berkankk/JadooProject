using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
