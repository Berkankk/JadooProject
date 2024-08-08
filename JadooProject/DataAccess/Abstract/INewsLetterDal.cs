using JadooProject.DataAccess.Entities;

namespace JadooProject.DataAccess.Abstract
{
    public interface INewsLetterDal : IRepository<NewsLetter>
    {
        int GetNewsLetterCount();
    }
}
