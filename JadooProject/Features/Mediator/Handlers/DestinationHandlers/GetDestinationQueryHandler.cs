using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Commands.DestinationCommands;
using JadooProject.Features.Mediator.Queries.DestinationQueries;
using JadooProject.Features.Mediator.Results.DestinationResult;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.Features.Mediator.Handlers.DestinationHandlers
{
    public class GetDestinationQueryHandler : IRequestHandler<GetDestinationQuery, List<GetDestinationQueryResults>>
    {
        private readonly JadooContext _context;

        public GetDestinationQueryHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task<List<GetDestinationQueryResults>> Handle(GetDestinationQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Destinations.ToListAsync();

            var destinationList = (from x in values select new GetDestinationQueryResults
            {
                DestinationID = x.DestinationID,
                City = x.City,
                Duration = x.Duration,
                ImageUrl = x.ImageUrl,
                Price = x.Price

            }).ToList();
            return destinationList;
        }
    }
}


//public int DestinationID { get; set; }
//public string ImageUrl { get; set; }
//public string City { get; set; }
//public string Duration { get; set; }
//public decimal Price { get; set; }