using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EfBrandDal : Repository<Brand>, IBrandDal
    {
        public EfBrandDal(JadooContext context) : base(context)
        {
        }

        public int GetBrandCount()
        {
            var context = new JadooContext();
            return context.Brands.Count();
        }
    }
}
