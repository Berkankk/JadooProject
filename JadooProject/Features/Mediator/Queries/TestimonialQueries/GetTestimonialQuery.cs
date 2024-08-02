using JadooProject.DataAccess.Entities;
using JadooProject.Features.Mediator.Results.TestimonialResult;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
    {
        //Geriye dönüş tipi liste türünde query result sınıfı dönecek 
        //Burası bir request işlemi 
    }
}
