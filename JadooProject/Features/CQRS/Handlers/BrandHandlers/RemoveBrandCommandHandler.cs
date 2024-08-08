using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.BrandCommands;

namespace JadooProject.Features.CQRS.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler
    {
        private readonly IRepository<Brand> _brandRepository;

        public RemoveBrandCommandHandler(IRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public void Handle(RemoveBrandCommand command)
        {
            _brandRepository.Delete(command.ID);
        }
    }
}
