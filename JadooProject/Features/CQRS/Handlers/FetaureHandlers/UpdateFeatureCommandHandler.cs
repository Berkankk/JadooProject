using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.FeatureCommands;

namespace JadooProject.Features.CQRS.Handlers.FetaureHandlers
{
    public class UpdateFeatureCommandHandler
    {
        private readonly IRepository<Feature> _repository;

        public UpdateFeatureCommandHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public void Handle(UpdateFeatureCommand updateFeatureCommand)
        {
            var feature = new Feature
            {
                ImageUrl = updateFeatureCommand.ImageUrl,
                LongDescription = updateFeatureCommand.LongDescription,
                ShortDescription = updateFeatureCommand.ShortDescription,
                LowerDescription = updateFeatureCommand.LowerDescription,
                FeatureID = updateFeatureCommand.FeatureID
            };
            _repository.Update(feature);

        }
    }
}
