using JadooProject.DataAccess.Abstract;
using JadooProject.Features.CQRS.Results.DestinationResults;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationHomeQueryHandler
    {
        private readonly IDestinationDal _destination;

        public GetDestinationHomeQueryHandler(IDestinationDal destination)
        {
            _destination = destination;
        }

        public List<GetDestinationHomeQueryResult> Handle()
        {
            var value = _destination.GetLast3Destination();

            List<GetDestinationHomeQueryResult> results = (from x in value select new GetDestinationHomeQueryResult
            {
                City = x.City,
                DestinationID = x.DestinationID,
                Duration = x.Duration,
                ImageUrl = x.ImageUrl,
                Price = x.Price
            }).ToList();
            return results;
        }
    }
}
