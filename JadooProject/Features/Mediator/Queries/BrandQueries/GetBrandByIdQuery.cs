using JadooProject.Features.Mediator.Results.BrandResult;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.BrandQueries
{
    public class GetBrandByIdQuery : IRequest<GetBrandByIdQueryResult>
    {
        public int ID { get; set; }

        public GetBrandByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
