using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.ManuelCommands;

namespace JadooProject.Features.CQRS.Handlers.ManuelHandlers
{
    public class UpdateManuelCommandHandler
    {
        private readonly IRepository<Manuel> _repository;

        public UpdateManuelCommandHandler(IRepository<Manuel> repository)
        {
            _repository = repository;
        }

        public void Handle(UpdateManuelComman updateManuelComman)
        {
            var manuel = new Manuel
            {
                Description = updateManuelComman.Description,
                Icon = updateManuelComman.Icon,
                ManuelID = updateManuelComman.ManuelID,
                Title = updateManuelComman.Title
            };
            _repository.Update(manuel);  //manuelde mapping işlemimi yaptığımız için _repository de onu verdik
        }
    }
}
