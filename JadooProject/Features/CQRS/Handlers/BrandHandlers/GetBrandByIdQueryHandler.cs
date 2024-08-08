using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Queries.DestinationQueries;
using JadooProject.Features.CQRS.Results.BrandResults;

namespace JadooProject.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _brandRepository;

        public GetBrandByIdQueryHandler(IRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public GetBrandByIdQueryResult Handle(GetDestinationByIdQuery getDestinationByIdQuery)
        {
            var value = _brandRepository.GetByID(getDestinationByIdQuery.ID);

            GetBrandByIdQueryResult result = new GetBrandByIdQueryResult();
            result.BrandID = value.BrandID;
            result.ImageUrl = value.ImageUrl;
            return result;
        }
    }
}
