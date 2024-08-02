using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Queries.BrandQueries;
using JadooProject.Features.Mediator.Results.BrandResult;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.Features.Mediator.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler : IRequestHandler<GetBrandByIdQuery, GetBrandByIdQueryResult>
    {
        private readonly JadooContext _context;

        public GetBrandByIdQueryHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Brands.FirstOrDefaultAsync(x => x.BrandID == request.ID);

            var brand = new GetBrandByIdQueryResult
            {
                BrandID = value.BrandID,
                ImageUrl = value.ImageUrl
            };
            return brand;
        }
    }
}
