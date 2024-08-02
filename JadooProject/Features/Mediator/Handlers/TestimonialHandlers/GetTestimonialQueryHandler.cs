using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Queries.TestimonialQueries;
using JadooProject.Features.Mediator.Results.TestimonialResult;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        private readonly JadooContext _context;

        public GetTestimonialQueryHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Testimonials.ToListAsync();

            var testimonialList = (from x in values
                                   select new GetTestimonialQueryResult
                                   {
                                       TestimonialID = x.TestimonialID,
                                       ImageUrl = x.ImageUrl,
                                       Comment = x.Comment,
                                       NameSurname = x.NameSurname,
                                       Country = x.Country,

                                   }).ToList();
            return testimonialList;

        }
    }
}
