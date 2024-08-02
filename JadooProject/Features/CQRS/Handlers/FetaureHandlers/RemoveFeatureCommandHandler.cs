using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.FeatureCommands;

namespace JadooProject.Features.CQRS.Handlers.FetaureHandlers
{
    public class RemoveFeatureCommandHandler
    {
        private readonly IRepository<Feature> _repository;

        public RemoveFeatureCommandHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public void Handle(RemoveFeatureCommand command)  //Metodu tanımladık command oluşturduğumuz sınıfı verdik sonrasında da _repositoryden gelen delete metodu ile parametreden gelen id değerini sildik
        {
            _repository.Delete(command.ID);
        }
    }
}
