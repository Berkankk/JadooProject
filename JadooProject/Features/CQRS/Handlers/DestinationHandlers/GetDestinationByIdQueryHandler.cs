using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Queries.DestinationQueries;
using JadooProject.Features.CQRS.Results.DestinationResults;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly IRepository<Destination> _destinationRepository;

        public GetDestinationByIdQueryHandler(IRepository<Destination> destinationRepository)
        {
            _destinationRepository = destinationRepository;
        }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var value = _destinationRepository.GetByID(query.ID);

            GetDestinationByIdQueryResult result = new GetDestinationByIdQueryResult();
            result.Duration = value.Duration;
            result.DestinationID = value.DestinationID;
            result.ImageUrl = value.ImageUrl;
            result.City = value.City;
            result.Price = value.Price;
            return result;

            //valuedan gelen değer ile resulttan gelen değeri mapledik
        }
    }
}
