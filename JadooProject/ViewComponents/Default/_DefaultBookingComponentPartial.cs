using JadooProject.Features.CQRS.Handlers.ManuelHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Default
{
    public class _DefaultBookingComponentPartial : ViewComponent
    {
        private readonly GetManuelQueryHandler _manuelQueryHandler;

        public _DefaultBookingComponentPartial(GetManuelQueryHandler manuelQueryHandler)
        {
            _manuelQueryHandler = manuelQueryHandler;
        }

        public IViewComponentResult Invoke()
        {
            var value = _manuelQueryHandler.Handle();
            return View(value);
        }
    }
}
