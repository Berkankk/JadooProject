using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.FeatureCommands;

namespace JadooProject.Features.CQRS.Handlers.FetaureHandlers
{
    public class CreateFeatureCommandHanler
    {
        private readonly IRepository<Feature> _repository;

        public CreateFeatureCommandHanler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public void Handle(CreateFeatureCommand createFeature)
        {
            var feature = new Feature
            {
                ImageUrl = createFeature.ImageUrl,
                LongDescription = createFeature.LongDescription,
                ShortDescription = createFeature.ShortDescription,
                LowerDescription = createFeature.LowerDescription,
            };
            _repository.Create(feature);
        }
    }
}
