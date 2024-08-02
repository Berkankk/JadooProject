using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Queries.FeatureQueries;
using JadooProject.Features.CQRS.Queries.ManuelQueries;
using JadooProject.Features.CQRS.Results.FeatureResults;
using JadooProject.Features.CQRS.Results.ManuelResults;

namespace JadooProject.Features.CQRS.Handlers.ManuelHandlers
{
    public class GetManuelByIdQueryHandler
    {
        private readonly IRepository<Manuel> _manuelRepository;

        public GetManuelByIdQueryHandler(IRepository<Manuel> manuelRepository)
        {
            _manuelRepository = manuelRepository;
        }

        public GetManuelByIdQueryResult Handle(GetManuelByIdQuery getManuelByIdQuery)
        {
            var value = _manuelRepository.GetByID(getManuelByIdQuery.ID);

            GetManuelByIdQueryResult result = new GetManuelByIdQueryResult();

            result.ManuelID = value.ManuelID;
            result.Description = value.Description;
            result.Title = value.Title;
            result.Icon = value.Icon;

            return result;
        }
    }
}
