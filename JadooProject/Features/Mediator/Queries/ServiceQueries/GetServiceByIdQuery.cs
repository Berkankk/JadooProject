using JadooProject.Features.Mediator.Results.ServiceResult;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceByIdQuery : IRequest<GetServiceByIdQueryResult>
    {
        //Constructor işlemini yapacağız

        public int ID { get; set; }

        public GetServiceByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
