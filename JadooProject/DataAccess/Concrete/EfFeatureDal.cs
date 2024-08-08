using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EfFeatureDal : Repository<Feature>, IFeatureDal
    {
        public EfFeatureDal(JadooContext context) : base(context)
        {
        }

        public int GetFeatureCount()
        {
            var context = new JadooContext();
            return context.Features.Count();
        }
    }
}
