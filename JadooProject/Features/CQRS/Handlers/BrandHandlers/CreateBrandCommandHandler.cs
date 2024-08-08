using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.BrandCommands;

namespace JadooProject.Features.CQRS.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler
    {
        private readonly IRepository<Brand> _brandRepository;

        public CreateBrandCommandHandler(IRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public void Handle(CreateBrandCommand command)
        {
            var brand = new Brand
            {
                ImageUrl = command.ImageUrl
            };
            _brandRepository.Create(brand);
        }
    }
}
