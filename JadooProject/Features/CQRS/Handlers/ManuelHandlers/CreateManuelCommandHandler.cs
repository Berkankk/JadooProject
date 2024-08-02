using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.ManuelCommands;

namespace JadooProject.Features.CQRS.Handlers.ManuelHandlers
{
    public class CreateManuelCommandHandler
    {
        private readonly IRepository<Manuel> _repository;

        public CreateManuelCommandHandler(IRepository<Manuel> repository)
        {
            _repository = repository;
        }

        public void Handle(CreateManuelCommand command)
        {
            var manuel = new Manuel
            {
                Description = command.Description,
                Icon = command.Icon,
                Title = command.Title,
            };
            _repository.Create(manuel);

        }
    }
}
