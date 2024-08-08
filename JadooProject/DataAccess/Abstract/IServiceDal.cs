using JadooProject.DataAccess.Entities;

namespace JadooProject.DataAccess.Abstract
{
    public interface IServiceDal : IRepository<Service>
    {
        int getServiceCount();
    }
}
