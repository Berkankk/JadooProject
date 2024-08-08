using JadooProject.Features.CQRS.Handlers.DestinationHandlers;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace JadooProject.ViewComponents.Default
{
    public class _DefaultLastDestinationComponentPartial : ViewComponent
    {
        private readonly GetLastDestinationQueryHandler _handler;

        public _DefaultLastDestinationComponentPartial(GetLastDestinationQueryHandler handler)
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
