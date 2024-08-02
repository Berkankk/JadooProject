using JadooProject.Features.CQRS.Commands.NewsLetterCommands;
using JadooProject.Features.CQRS.Handlers.NewsLetterHandlers;
using JadooProject.Features.CQRS.Queries.NewsLetterQueries;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Controllers
{
    public class NewsLetterController : Controller
    {
        private readonly GetNewsLetterQueryHandle _queryHandle;
        private readonly GetNewsLetterByIdQueryHandle _queryHandleById;
        private readonly UpdateNewsLetterCommandHandler _updateHandler;
        private readonly CreateNewsLetterCommandHandler _createHandler;
        private readonly RemoveNewsLetterCommandHandler _removeHandler;
        public NewsLetterController(GetNewsLetterQueryHandle queryHandle, GetNewsLetterByIdQueryHandle queryHandleById, UpdateNewsLetterCommandHandler updateHandler, CreateNewsLetterCommandHandler createHandler)
        {
            _queryHandle = queryHandle;
            _queryHandleById = queryHandleById;
            _updateHandler = updateHandler;
            _createHandler = createHandler;
        }

        public IActionResult Index()
        {
            var values = _queryHandle.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateNewsLetter(int id)
        {
            var value = _queryHandleById.Handle(new GetNewsLetterByIdQuery(id));
            var newsletter = new UpdateNewsLetterCommand
            {
                Email = value.Email,
                NewsLetterID = value.NewsLetterID
            };
            return View(newsletter);
        }
        [HttpPost]
        public IActionResult UpdateNewsLetter(UpdateNewsLetterCommand command)
        {
            _updateHandler.Handle(command);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateNewsLetter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNewsLetter(CreateNewsLetterCommand command)
        {
            _createHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteNewsLetter(int id)
        {
            _removeHandler.Handle(new RemoveNewsLetterCommand(id));
            return RedirectToAction("Index");
        }
    }
}
