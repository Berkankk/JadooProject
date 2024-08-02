using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.DestinationCommands;
using JadooProject.Features.CQRS.Handlers.DestinationHandlers;
using JadooProject.Features.CQRS.Queries.DestinationQueries;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Controllers
{
    public class DestinationController : Controller
    {
        //oluşturduğumuz handler ı burada geçtik 
        //Ve bu ctoru programcs tarafında vermemiz lazım

        private readonly GetDestinationQueryHandler _handler;
        private readonly GetDestinationByIdQueryHandler _queryıdHandler;
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
        private readonly RemoveDestinationCommandHandler _removeDestinationCommandHandler;
        private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;

        public DestinationController(GetDestinationQueryHandler handler, GetDestinationByIdQueryHandler queryHandler, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler)
        {
            _handler = handler;
            _queryıdHandler = queryHandler;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _removeDestinationCommandHandler = removeDestinationCommandHandler;
            _updateDestinationCommandHandler = updateDestinationCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _handler.Handle();
            return View(values);  
            //liste türünde dönüyor 
        }
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var value = _queryıdHandler.Handle(new GetDestinationByIdQuery(id));  //id ye göre değer dönüyor ve mapleme yaptık

            var destination = new UpdateDestinationCommand
            {
                City = value.City,
                ImageUrl = value.ImageUrl,
                Price = value.Price,
                DestinationID = id,
                Duration = value.Duration,
            };
            return View(destination);
        }

        [HttpPost]
        public IActionResult UpdateDestination(UpdateDestinationCommand update)
        {
            _updateDestinationCommandHandler.Handle(update);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult CreateDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateDestination(CreateDestinationCommand command)
        {
            _createDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDestination(int id)
        {
            _removeDestinationCommandHandler.Handle(new RemoveDestinationCommand(id));
            return RedirectToAction("Index");
        }


    }
}
