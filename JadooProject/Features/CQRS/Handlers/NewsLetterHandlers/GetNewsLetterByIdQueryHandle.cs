using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.NewsLetterCommands;
using JadooProject.Features.CQRS.Queries.NewsLetterQueries;
using JadooProject.Features.CQRS.Results.NewsLetterResults;

namespace JadooProject.Features.CQRS.Handlers.NewsLetterHandlers
{
    public class GetNewsLetterByIdQueryHandle
    {
        private readonly IRepository<NewsLetter> _newsLetterRepository;

        public GetNewsLetterByIdQueryHandle(IRepository<NewsLetter> newsLetterRepository)
        {
            _newsLetterRepository = newsLetterRepository;
        }

        public GetNewLetterByIdQueryResult Handle(GetNewsLetterByIdQuery getNewsLetterByIdQuery)
        {
            var value = _newsLetterRepository.GetByID(getNewsLetterByIdQuery.ID);

            GetNewLetterByIdQueryResult result = new GetNewLetterByIdQueryResult();

            result.NewsLetterID = value.NewsLetterID;
            result.Email = value.Email;

            return result;
        }
    }
}
