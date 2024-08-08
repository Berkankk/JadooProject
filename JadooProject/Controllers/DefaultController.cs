using JadooProject.Features.CQRS.Commands.NewsLetterCommands;
using JadooProject.Features.CQRS.Results.DestinationResults;
using JadooProject.Features.Mediator.Queries.DestinationQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMediator _mediator;

        public DefaultController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SubscribeEmail(CreateNewsLetterCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Destinations()
        {
            var values = await _mediator.Send(new GetDestinationQuery());
            return View(values);
        }

        public async Task<IActionResult> GetDestinationDetail(int id)
        {
            var value = await _mediator.Send(new GetDestinationByIdQuery(id));
            return View(value);
        }
    }
}
