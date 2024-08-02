using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.NewsLetterCommands;

namespace JadooProject.Features.CQRS.Handlers.NewsLetterHandlers
{
    public class CreateNewsLetterCommandHandler
    {
        private readonly IRepository<NewsLetter> _newsLetterRepository;

        public CreateNewsLetterCommandHandler(IRepository<NewsLetter> newsLetterRepository)
        {
            _newsLetterRepository = newsLetterRepository;
        }

        public void Handle(CreateNewsLetterCommand command)
        {
            var newsLetter = new NewsLetter
            {
                Email = command.Email,
            };
            _newsLetterRepository.Create(newsLetter);
        }
    }
}
