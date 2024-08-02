using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.DestinationCommands;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly IRepository<Destination> _repository;

        public CreateDestinationCommandHandler(IRepository<Destination> repository)
        {
            _repository = repository;
        }

        public void Handle(CreateDestinationCommand command)
        {
            var destination = new Destination
            {
                City = command.City,
                Duration = command.Duration,
                Price = command.Price,
                ImageUrl = command.ImageUrl,
            };
            _repository.Create(destination);
        }
    }
}
