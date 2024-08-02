using JadooProject.Features.CQRS.Commands.ManuelCommands;
using JadooProject.Features.CQRS.Handlers.ManuelHandlers;
using JadooProject.Features.CQRS.Queries.ManuelQueries;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Controllers
{
    public class ManuelController : Controller
    {
        private readonly GetManuelQueryHandler _handler;
        private readonly GetManuelByIdQueryHandler _handlerById;
        private readonly UpdateManuelCommandHandler _updateManuel;
        private readonly CreateManuelCommandHandler _createManuel;
        private readonly RemoveManuelCommandHandler _removeManuel;
        public ManuelController(GetManuelQueryHandler handler, GetManuelByIdQueryHandler handlerById, UpdateManuelCommandHandler updateManuel, CreateManuelCommandHandler createManuel, RemoveManuelCommandHandler removeManuel)
        {
            _handler = handler;
            _handlerById = handlerById;
            _updateManuel = updateManuel;
            _createManuel = createManuel;
            _removeManuel = removeManuel;
        }

        public IActionResult Index()
        {
            var values = _handler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateManuel(int id)
        {
            var values = _handlerById.Handle(new GetManuelByIdQuery(id));

            var manuel = new UpdateManuelComman
            {
                Description = values.Description,
                Icon = values.Icon,
                ManuelID = values.ManuelID,
                Title = values.Title
            };
            return View(manuel);
        }
        [HttpPost]
        public IActionResult UpdateManuel(UpdateManuelComman updateManuelComman)
        {
            _updateManuel.Handle(updateManuelComman);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateManuel()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateManuel(CreateManuelCommand command)
        {
            _createManuel.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteManuel(int id)
        {
            _removeManuel.Handle(new RemoveManuelCommand(id));
            return RedirectToAction("Index");
        }



    }
}
