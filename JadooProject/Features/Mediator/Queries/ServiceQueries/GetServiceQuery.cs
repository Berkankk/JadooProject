using JadooProject.Features.Mediator.Results.ServiceResult;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceQuery : IRequest<List<GetServiceQueryresult>>
    {
        //Geriye dönüş tipi liste türünde query result sınıfı dönecek 
        //Burası bir request işlemi 
    }
}
