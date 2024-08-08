using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.UILayout
{
    public class _UILayoutScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
