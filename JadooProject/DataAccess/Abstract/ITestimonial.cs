using JadooProject.DataAccess.Entities;

namespace JadooProject.DataAccess.Abstract
{
    public interface ITestimonial : IRepository<Testimonial>
    {
        int GetTestimonailCount();
        List<Testimonial> GetTestimonailsForDashboard();
    }
}
