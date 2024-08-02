using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.Mediator.Commands.BrandCommands;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand>
    {
        private readonly JadooContext _context;

        public CreateBrandCommandHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = new Brand
            {
                ImageUrl = request.ImageUrl
            };

            await _context.Brands.AddAsync(brand);
            await _context.SaveChangesAsync();
        }
    }
}

//Neler yaptık öncelikle implemente edilecek yeeri verdik ,sonra context tarafında implemente işlemini yaptık ve devamında manuel mapledik