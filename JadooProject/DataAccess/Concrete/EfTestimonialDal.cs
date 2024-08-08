using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EfTestimonialDal : Repository<Testimonial>, ITestimonial
    {
        public EfTestimonialDal(JadooContext context) : base(context)
        {
        }

        public int GetTestimonailCount()
        {
           var context = new JadooContext();
            return context.Testimonials.Count();
        }

        public List<Testimonial> GetTestimonailsForDashboard()
        {
            var context = new JadooContext();
            return context.Testimonials.Take(6).ToList();
        }
    }
}
