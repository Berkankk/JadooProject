using JadooProject.Features.Mediator.Commands.TestimonialCommands;
using JadooProject.Features.Mediator.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly IMediator _mediator;

        public TestimonialController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetTestimonialQuery());
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var value = await _mediator.Send(new GetTestimonialByIdQuery(id));

            var testimonial = new UpdateTestimonialCommand
            {
                TestimonialID = value.TestimonialID,
                Comment = value.Comment,
                Country = value.Country,
                ImageUrl = value.ImageUrl,
                NameSurname = value.NameSurname
            };
            return View(testimonial);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _mediator.Send(new RemoveTestimonialCommand(id));  //Dahil edip içine silme işlemini geçiyoruz id ye göre siliyoruz
            return RedirectToAction("Index");
        }
    }
}
