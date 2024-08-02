using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.NewsLetterCommands;

namespace JadooProject.Features.CQRS.Handlers.NewsLetterHandlers
{
    public class RemoveNewsLetterCommandHandler
    {
        private readonly IRepository<NewsLetter> _newsLetterRepository;

        public RemoveNewsLetterCommandHandler(IRepository<NewsLetter> newsLetterRepository)
        {
            _newsLetterRepository = newsLetterRepository;
        }

        public void Handle(RemoveNewsLetterCommand command)
        {
            _newsLetterRepository.Delete(command.ID);
        }
    }
}
