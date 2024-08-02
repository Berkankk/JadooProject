using JadooProject.Features.CQRS.Commands.DestinationCommands;
using JadooProject.Features.CQRS.Commands.FeatureCommands;
using JadooProject.Features.CQRS.Handlers.FetaureHandlers;
using JadooProject.Features.CQRS.Queries.DestinationQueries;
using JadooProject.Features.CQRS.Queries.FeatureQueries;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Controllers
{
    public class FeatureController : Controller
    {
        private readonly GetFeatureQueryHandler _handler;
        private readonly GetFeatureByIdQueryHandler _queryHandler;
        private readonly UpdateFeatureCommandHandler _updateFeatureCommand;
        private readonly CreateFeatureCommandHanler _createCommand;
        private readonly RemoveFeatureCommandHandler _removeFeatureCommand;

        public FeatureController(GetFeatureQueryHandler handler, GetFeatureByIdQueryHandler queryHandler, UpdateFeatureCommandHandler updateFeatureCommand, CreateFeatureCommandHanler createCommand)
        {
            _handler = handler;
            _queryHandler = queryHandler;
            _updateFeatureCommand = updateFeatureCommand;
            _createCommand = createCommand;
        }

        public IActionResult Index()
        {
            var values = _handler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var value = _queryHandler.Handle(new GetFeatureByIdQuery(id));  //id ye göre değer dönüyor ve mapleme yaptık

            var feature = new UpdateFeatureCommand
            {
                ImageUrl = value.ImageUrl,
                LongDescription = value.LongDescription,
                ShortDescription = value.ShortDescription,
                LowerDescription = value.LowerDescription,
                FeatureID = value.FeatureID

            };
            return View(feature);
        }
        [HttpPost]
        public IActionResult UpdateFeature(UpdateFeatureCommand updateFeature)
        {
            _updateFeatureCommand.Handle(updateFeature);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureCommand featureCommand)
        {
            _createCommand.Handle(featureCommand);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteFeature(int id)
        {
            _removeFeatureCommand.Handle(new RemoveFeatureCommand(id));
            return RedirectToAction("Index");
        }

    }

}
