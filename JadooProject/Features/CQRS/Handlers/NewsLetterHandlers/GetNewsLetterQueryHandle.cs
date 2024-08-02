using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Results.NewsLetterResults;

namespace JadooProject.Features.CQRS.Handlers.NewsLetterHandlers
{
    public class GetNewsLetterQueryHandle
    {
        private readonly IRepository<NewsLetter> _newsLetterRepository;

        public GetNewsLetterQueryHandle(IRepository<NewsLetter> newsLetterRepository)
        {
            _newsLetterRepository = newsLetterRepository;
        }

        public List<GetNewsLetterQueryResult> Handle()
        {
            var values = _newsLetterRepository.GetList();

            List<GetNewsLetterQueryResult> result = (from x in values
                                                     select new GetNewsLetterQueryResult
                                                     {
                                                            Email = x.Email,
                                                            NewsLetterID = x.NewsLetterID
                                                     }).ToList();
            return result;
        }

    }
}
