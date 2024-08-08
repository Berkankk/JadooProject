using JadooProject.DataAccess.Abstract;
using JadooProject.Features.CQRS.Results.DestinationResults;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class GetLastDestinationQueryHandler
    {
        private readonly IDestinationDal _destinationDal;

        public GetLastDestinationQueryHandler(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public GetLastDestinationQueryResult Handle()
        {
            var value = _destinationDal.GetLastDestination();

            GetLastDestinationQueryResult result = new GetLastDestinationQueryResult();
            result.Duration = value.Duration;
            result.DestinationID = value.DestinationID;
            result.ImageUrl = value.ImageUrl;
            result.City = value.City;
            result.Price = value.Price;
            return result;

        }

    }
}
