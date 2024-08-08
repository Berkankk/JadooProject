using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Queries.DestinationQueries;
using JadooProject.Features.Mediator.Results.DestinationResult;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.Features.Mediator.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler : IRequestHandler<GetDestinationByIdQuery, GetDestinationByIdQueryResults>
    {
        private readonly JadooContext _context;

        public GetDestinationByIdQueryHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task<GetDestinationByIdQueryResults> Handle(GetDestinationByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Destinations.FirstOrDefaultAsync(x => x.DestinationID == request.ID);

            var destination = new GetDestinationByIdQueryResults
            {
                City = value.City,
                DestinationID = value.DestinationID,
                Duration = value.Duration,
                ImageUrl = value.ImageUrl,
                Price = value.Price
            };
            return destination;
        }
    }
}
