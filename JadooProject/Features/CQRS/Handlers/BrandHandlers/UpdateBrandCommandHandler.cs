using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.BrandCommands;

namespace JadooProject.Features.CQRS.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;

        public UpdateBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async void Handle(UpdateBrandCommand command)
        {
            var brand = new Brand
            {
                BrandID = command.BrandID,
                ImageUrl = command.ImageUrl
            };
            _repository.Update(brand);
            
        }
    }
}
