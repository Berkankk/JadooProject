using JadooProject.Features.Mediator.Commands.ServiceCommands;
using JadooProject.Features.Mediator.Handlers.ServiceHandlers;
using JadooProject.Features.Mediator.Queries.ServiceQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IMediator _mediator;   //Havaalanındaki kule gibi düşün bunu CQRS de tek tek ctor yaptık bunda tek bir tane ctor ile tüm hepsinin yönetebiliyorum 

        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetServiceQuery());
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateService(int id)
        {
            var value = await _mediator.Send(new GetServiceByIdQuery(id));

            var serive = new UpdateServiceCommand
            {
                ServiceID = value.ServiceID,
                Icon = value.Icon,
                Title = value.Title,
                Description = value.Description

            };

            return View(serive);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateService(UpdateServiceCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
            //Create işlemi command de geçtiğimiz için parametre olarak onu verdik dto gibi aynı
        }
        public async Task<IActionResult> DeleteService(int id)
        {
            await _mediator.Send(new RemoveServiceCommand(id));
            return RedirectToAction("Index");
        }
    }
}
