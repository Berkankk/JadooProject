using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Queries.FeatureQueries;
using JadooProject.Features.CQRS.Results.FeatureResults;

namespace JadooProject.Features.CQRS.Handlers.FetaureHandlers
{
    public class GetFeatureByIdQueryHandler
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public GetFeatureByIdQueryResult Handle(GetFeatureByIdQuery getFeatureByIdQuery)
        {
            var value = _repository.GetByID(getFeatureByIdQuery.ID);

            GetFeatureByIdQueryResult result = new GetFeatureByIdQueryResult();

            result.LowerDescription = value.LowerDescription;
            result.ShortDescription = value.ShortDescription;
            result.LongDescription = value.LongDescription;
            result.FeatureID = value.FeatureID;
            result.ImageUrl = value.ImageUrl;

            return result;

        }
    }
}
