using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Results.BrandResults;

namespace JadooProject.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public  List<GetBrandQueryResult> Handle()
        {
            var values = _repository.GetList();

            List<GetBrandQueryResult> results = (from x in values select new GetBrandQueryResult
            {
                BrandID = x.BrandID,
                ImageUrl = x.ImageUrl

            }).ToList();
            return results;
        }
    }
}
