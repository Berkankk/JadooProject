using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Results.FeatureResults;

namespace JadooProject.Features.CQRS.Handlers.FetaureHandlers
{
    public class GetFeatureQueryHandler
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public List<GetFeatureQueryResult> Handle()
        {
            var values = _repository.GetList();
            //values liste türünde geriye değer dönüyor ama biz queryresult olsun istiyoruz bu yüzden mapleme işlemi yapacağız

            List<GetFeatureQueryResult> result = (from x in values
                                                  select new GetFeatureQueryResult
                                                  {
                                                      //Automapper ı burada elimizlen tek tek yazacağız
                                                      FeatureID = x.FeatureID,
                                                      ShortDescription = x.ShortDescription,
                                                      LongDescription = x.LongDescription,
                                                      LowerDescription = x.LowerDescription,
                                                      ImageUrl = x.ImageUrl
                                                  }).ToList();
            return result; //result ı mapledik bu yüzden result dönüyoruz


        }
    }
}
