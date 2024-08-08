using JadooProject.DataAccess.Entities;

namespace JadooProject.DataAccess.Abstract
{
    public interface IFeatureDal : IRepository<Feature>
    {
        int GetFeatureCount();
    }
}
