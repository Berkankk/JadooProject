using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Results.ManuelResults;

namespace JadooProject.Features.CQRS.Handlers.ManuelHandlers
{
    public class GetManuelQueryHandler
    {
        private readonly IRepository<Manuel> _manuelRepository;

        public GetManuelQueryHandler(IRepository<Manuel> manuelRepository)
        {
            _manuelRepository = manuelRepository;
        }

        public List<GetManuelQueryResult> Handle()
        {
            var values = _manuelRepository.GetList();    //manuel bir şekilde mapleme yaptık 

            List<GetManuelQueryResult> result = (from x in values
                                                 select new GetManuelQueryResult
                                                 {
                                                     Description = x.Description,
                                                     Icon = x.Icon,
                                                     ManuelID = x.ManuelID,
                                                     Title = x.Title
                                                 }).ToList();

            return result;


        }
    }
}
