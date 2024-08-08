using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EfDestinationDal : Repository<Destination>, IDestinationDal
    {
        public EfDestinationDal(JadooContext context) : base(context)
        {
        }

        public int getDestinationCount()
        {
            var context = new JadooContext();
            return context.Destinations.Count();
        }

        public List<Destination> GetLast3Destination()
        {
            var context = new JadooContext();
            return context.Destinations.OrderByDescending(x => x.DestinationID).Take(3).ToList();
        }

        public List<Destination> GetLast6Destination()
        {
            var context = new JadooContext();
            return context.Destinations.OrderByDescending(x => x.DestinationID).Take(6).ToList();
        }

        public Destination GetLastDestination()
        {
            var context = new JadooContext();
            return context.Destinations.OrderByDescending(x => x.DestinationID).Take(1).FirstOrDefault();
        }
    }
}
