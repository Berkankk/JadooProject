using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EfNewsLetterDal : Repository<NewsLetter>, INewsLetterDal
    {
        public EfNewsLetterDal(JadooContext context) : base(context)
        {
        }

        public int GetNewsLetterCount()
        {
            var context = new JadooContext();
            return context.NewsLetters.Count();
        }
    }
}
