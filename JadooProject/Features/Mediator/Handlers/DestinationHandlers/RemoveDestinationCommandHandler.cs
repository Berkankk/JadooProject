using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Commands.DestinationCommands;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler : IRequestHandler<RemoveDestinationCommand>
    {
        private readonly JadooContext _context;

        public RemoveDestinationCommandHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveDestinationCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Destinations.FindAsync(request.ID);
            _context.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}

//Neler yaptık öncelikle id den gelen değerleri eşit mi değil mi diye bi sorguladık devamında eğer eşitse sil onu dedik ve değişiklikleri kaydettik
