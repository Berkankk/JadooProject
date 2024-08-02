using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.Mediator.Commands.TestimonialCommands;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.TestimonialHandlers
{
    public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
    {
        private readonly JadooContext _context;

        public UpdateTestimonialCommandHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var testimonial = new Testimonial
            {
                Comment = request.Comment,
                Country = request.Country,
                ImageUrl = request.ImageUrl,
                NameSurname = request.NameSurname,
                TestimonialID = request.TestimonialID,
            };

            _context.Update(testimonial);  //Update in asenkron metodu yok unutma 
            await _context.SaveChangesAsync();
        }
    }
}
