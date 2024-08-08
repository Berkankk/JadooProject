using JadooProject.Features.Mediator.Results.DestinationResult;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.DestinationQueries
{
    public class GetDestinationByIdQuery : IRequest<GetDestinationByIdQueryResults>
    {
        public int ID { get; set; }

        public GetDestinationByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
