using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Results.DestinationResults;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationQueryHandler
    {
        //Burada veritabanı işlemleri yapıyoruz bunun için ctor amaçlı ırepository den örnek alacağız

        private readonly IRepository<Destination> _repository;

        public GetDestinationQueryHandler(DataAccess.Abstract.IRepository<Destination> repository)
        {
            _repository = repository;
        }

        public List<GetDestinationQueryResult> Handle()
        {
            var values = _repository.GetList();   //values liste türünde geriye değer dönüyor ama biz queryresult olsun istiyoruz bu yüzden mapleme işlemi yapacağız

            List<GetDestinationQueryResult> results = (from x in values
                                                       select new GetDestinationQueryResult
                                                       {
                                                           City = x.City,
                                                           DestinationID = x.DestinationID,
                                                           Duration = x.Duration,
                                                           ImageUrl = x.ImageUrl,
                                                           Price = x.Price,
                                                           //Automapper ı burada elimizlen tek tek yazdık

                                                       }).ToList();
            return results;  //result türünde döndük 

        }


    }
}
