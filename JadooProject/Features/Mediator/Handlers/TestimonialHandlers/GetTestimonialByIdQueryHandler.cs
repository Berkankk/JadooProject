using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Queries.TestimonialQueries;
using JadooProject.Features.Mediator.Results.TestimonialResult;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        private readonly JadooContext _context;

        public GetTestimonialByIdQueryHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Testimonials.FirstOrDefaultAsync(x => x.TestimonialID == request.ID);

            var testimonial = new GetTestimonialByIdQueryResult
            {
                TestimonialID = value.TestimonialID,
                Country = value.Country,
                ImageUrl = value.ImageUrl,
                Comment = value.Comment,
                NameSurname = value.NameSurname
            };

            return testimonial;
        }
    }
}
