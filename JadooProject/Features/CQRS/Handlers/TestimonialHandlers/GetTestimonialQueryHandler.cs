using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Results.TestimonialResults;

namespace JadooProject.Features.CQRS.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public List<GetTestimonialQueryResult> Hanle()
        {
            var values = _repository.GetList();

            List<GetTestimonialQueryResult> result = (from x in values select new GetTestimonialQueryResult
            {

                TestimonialID = x.TestimonialID,
                ImageUrl = x.ImageUrl,
                Comment = x.Comment,
                NameSurname = x.NameSurname,
                Country = x.Country

            }).ToList();
            return result;

        }
    }
}
//public int TestimonialID { get; set; }
//public string ImageUrl { get; set; }
//public string Comment { get; set; }
//public string NameSurname { get; set; }
//public string Country { get; set; }