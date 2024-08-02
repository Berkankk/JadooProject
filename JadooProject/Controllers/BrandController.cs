using JadooProject.Features.Mediator.Commands.BrandCommands;
using JadooProject.Features.Mediator.Queries.BrandQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Controllers
{
    public class BrandController : Controller
    {
        private readonly IMediator _mediator;

        public BrandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetBrandQuery());   //Listeleme işlemini asenkron bir şekilde yaptık
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateBrand(int id)
        {
            var value = await _mediator.Send(new GetBrandByIdQuery(id));

            var brand = new UpdateBrandCommand
            {
                BrandID = value.BrandID,
                ImageUrl = value.ImageUrl
            };
            return View(brand);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBrand(UpdateBrandCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateBrand()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommand command)
        {
            await _mediator.Send(command);  
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteBrand(int id)
        {
            await _mediator.Send(new RemoveBrandCommand(id));
            return RedirectToAction("Index");
        }
    }
}
