using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.NewsLetterCommands;

namespace JadooProject.Features.CQRS.Handlers.NewsLetterHandlers
{
    public class UpdateNewsLetterCommandHandler
    {
        private readonly IRepository<NewsLetter> _newsLetterRepository;

        public UpdateNewsLetterCommandHandler(IRepository<NewsLetter> newsLetterRepository)
        {
            _newsLetterRepository = newsLetterRepository;
        }

        public void Handle(UpdateNewsLetterCommand command)
        {
            var newsLetter = new NewsLetter
            {
                Email = command.Email,
                NewsLetterID = command.NewsLetterID
            };
            _newsLetterRepository.Update(newsLetter);
        }
    }
}
