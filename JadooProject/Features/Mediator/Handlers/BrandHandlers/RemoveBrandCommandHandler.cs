using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Commands.BrandCommands;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler : IRequestHandler<RemoveBrandCommand>
    {
        private readonly JadooContext _context;

        public RemoveBrandCommandHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveBrandCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Brands.FindAsync(request.ID);   //Önce hangi id nin silineceğini buluyoruz
            _context.Remove(value); // sonra siliyoruz
            await _context.SaveChangesAsync();  // ve kaydediyoruz

        }
    }
}
