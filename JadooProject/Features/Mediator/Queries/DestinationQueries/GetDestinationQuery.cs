using JadooProject.Features.Mediator.Results.DestinationResult;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.DestinationQueries
{
    public class GetDestinationQuery : IRequest<List<GetDestinationQueryResults>>
    {
    }
}
