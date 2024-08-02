using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Queries.BrandQueries;
using JadooProject.Features.Mediator.Results.BrandResult;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.Features.Mediator.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler : IRequestHandler<GetBrandQuery, List<GetBrandQueryResult>>
    {
        private readonly JadooContext _context;

        public GetBrandQueryHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task<List<GetBrandQueryResult>> Handle(GetBrandQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Brands.ToListAsync();

            var brandList = (from x in values
                                select new GetBrandQueryResult
                                {
                                    BrandID = x.BrandID,
                                    ImageUrl = x.ImageUrl
                                }).ToList();

            return brandList;

        }
    }
}
