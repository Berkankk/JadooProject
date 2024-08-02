using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Queries.ServiceQueries;
using JadooProject.Features.Mediator.Results.ServiceResult;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryresult>>
    {
        // adım adıım önce query result ı tanımladık onu service queryde verdik burada da baştan bu yana neler yaptığımı söyleik Irequesthandler interface i bize yapıyı kendisi oluşturacak
        //asenkron metotlar ile çalışılır

        //CancellationToken operasyon yarım kaldığında işlemi geri alır 

        private readonly JadooContext _jadooContext;

        public GetServiceQueryHandler(JadooContext jadooContext)
        {
            _jadooContext = jadooContext;
        }

        public async Task<List<GetServiceQueryresult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await _jadooContext.Services.ToListAsync();

            //Dönüş tipimiz farklı olduğu için burada mapleme işlemi yapacağız

            var serviceList = (from x in values
                               select new GetServiceQueryresult
                               {
                                   Description = x.Description,
                                   Icon = x.Icon,
                                   ServiceID = x.ServiceID,
                                   Title = x.Title,
                               }).ToList();

            return serviceList;

        }
    }
}
