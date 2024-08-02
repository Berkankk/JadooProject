using JadooProject.Features.Mediator.Results.TestimonialResult;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialByIdQuery : IRequest<GetTestimonialByIdQueryResult>
    {
        public int ID { get; set; }

        public GetTestimonialByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
