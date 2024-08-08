using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.Mediator.Commands.DestinationCommands;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler : IRequestHandler<UpdateDestinationCommand>
    {
        private readonly JadooContext _context;

        public UpdateDestinationCommandHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateDestinationCommand request, CancellationToken cancellationToken)
        {
            var destination = new Destination
            {
                DestinationID = request.DestinationID,
                ImageUrl = request.ImageUrl,
                City = request.City,
                Duration = request.Duration,
                Price = request.Price
            };
            _context.Destinations.Update(destination);  //update in asenkron metodu olmadığı için awaiti buranın altında geçeceği
            await _context.SaveChangesAsync();  
        }
    }
}

//Neler yaptık öncelikle constructorımızı geçtik devamında implement ettik ve mappingle sonlandırdık

//public int DestinationID { get; set; }
//public string ImageUrl { get; set; }
//public string City { get; set; }
//public string Duration { get; set; }
//public decimal Price { get; set; }