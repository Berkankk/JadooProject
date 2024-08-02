using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.Mediator.Commands.TestimonialCommands;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand>
    {
        private readonly JadooContext _context;

        public CreateTestimonialCommandHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var testimonial = new Testimonial
            {
                Comment = request.Comment,
                Country = request.Country,
                ImageUrl = request.ImageUrl,
                NameSurname = request.NameSurname
            };

            await _context.Testimonials.AddAsync(testimonial);
            await _context.SaveChangesAsync();
        }
    }
}
