using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.DestinationCommands;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly IRepository<Destination> _repository;

        public UpdateDestinationCommandHandler(IRepository<Destination> repository)
        {
            _repository = repository;
        }

        public void Handle(UpdateDestinationCommand command)
        {
            //Mapleme işlemi yapacağız

            var destination = new Destination
            {
                City = command.City,
                Price = command.Price,
                ImageUrl = command.ImageUrl,
                DestinationID = command.DestinationID,
                Duration = command.Duration,
            };
            _repository.Update(destination);
        }
    }
}
