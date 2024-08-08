using JadooProject.DataAccess.Entities;

namespace JadooProject.DataAccess.Abstract
{
    public interface IBrandDal : IRepository<Brand>
    {
        int GetBrandCount();
    }
}
