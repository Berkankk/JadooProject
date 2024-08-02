using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.Mediator.Commands.BrandCommands;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand>
    {
        private readonly JadooContext _context;

        public UpdateBrandCommandHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            var brand = new Brand
            {
                BrandID = request.BrandID,
                ImageUrl = request.ImageUrl
            };
            _context.Brands.Update(brand);  //unutma update metodunun asenkronu yok 
            await _context.SaveChangesAsync();
        }
    }
}


//Neler yaptık ????  Burada maping işlemi yaptık güncellenecek veriler ile yani entity ile updatebrand tarafını hadi hoşçakal