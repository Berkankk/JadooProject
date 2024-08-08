using JadooProject.Features.CQRS.Handlers.DestinationHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Default
{
    public class _DefaultDestinationComponentPartial : ViewComponent
    {
        private readonly GetDestinationHomeQueryHandler _getDestinationHomeQueryHandler;

        public _DefaultDestinationComponentPartial(GetDestinationHomeQueryHandler getDestinationHomeQueryHandler)
        {
            _getDestinationHomeQueryHandler = getDestinationHomeQueryHandler;
        }

        public IViewComponentResult Invoke()
        {
            var value = _getDestinationHomeQueryHandler.Handle();
            return View(value);
        }
    }
}