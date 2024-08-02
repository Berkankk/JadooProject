using JadooProject.Features.Mediator.Results.BrandResult;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.BrandQueries
{
    public class GetBrandQuery : IRequest<List<GetBrandQueryResult>>
    { 
        //Geriye dönüş tipi liste türünde query result sınıfı dönecek 
        //Burası bir request işlemi 
    }
}
