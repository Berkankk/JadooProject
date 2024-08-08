using JadooProject.Features.CQRS.Handlers.FetaureHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Default
{
    public class _DefaultFeatureComponentPartial : ViewComponent
    {
        private readonly GetFeatureQueryHandler _handler;

        public _DefaultFeatureComponentPartial(GetFeatureQueryHandler handler)
        {
            _handler = handler;
        }

        public IViewComponentResult Invoke()
        {
            var value = _handler.Handle();
            return View(value);
        }
    }
}
