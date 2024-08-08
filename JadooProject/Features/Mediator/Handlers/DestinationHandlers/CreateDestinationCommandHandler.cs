using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.Mediator.Commands.DestinationCommands;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler : IRequestHandler<CreateDestinationCommand>
    {
        private readonly JadooContext _context;

        public CreateDestinationCommandHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateDestinationCommand request, CancellationToken cancellationToken)
        {
            var destination = new Destination
            {
                City = request.City,
                Duration = request.Duration,
                ImageUrl = request.ImageUrl,
                Price = request.Price
            };
            await _context.Destinations.AddAsync(destination);
            await _context.SaveChangesAsync();
        }
    }
}
