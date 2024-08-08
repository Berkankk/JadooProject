//using JadooProject.DataAccess.Abstract;
//using JadooProject.DataAccess.Entities;
//using JadooProject.Features.CQRS.Results.TestimonialResults;

//namespace JadooProject.Features.CQRS.Handlers.TestimonialHandlers
//{
//    public class GetTestimonialForDashboardQueryHandler
//    {
//        private readonly IRepository<Testimonial> _repository;
//        private readonly ITestimonial _testimonial;

//        public GetTestimonialForDashboardQueryHandler(IRepository<Testimonial> repository, ITestimonial testimonial)
//        {
//            _repository = repository;
//            _testimonial = testimonial;
//        }

//        public List<GetTestimonialForDashboardQueryResult> Handle()
//        {
//            var value = _testimonial.GetTestimonailsForDashboard();
            

//            GetTestimonialForDashboardQueryResult result = new GetTestimonialForDashboardQueryResult();

           

//        }
//    }
//}
