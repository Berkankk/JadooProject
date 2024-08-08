using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EfServiceDal : Repository<Service>, IServiceDal
    {
        public EfServiceDal(JadooContext context) : base(context)
        {
        }

        public int getServiceCount()
        {
            var context = new JadooContext();
            return context.Services.Count();
        }
    }
}
