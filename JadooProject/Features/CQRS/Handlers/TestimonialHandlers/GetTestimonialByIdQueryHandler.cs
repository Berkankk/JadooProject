using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Queries.TestimonialQueries;
using JadooProject.Features.CQRS.Results.TestimonialResults;

namespace JadooProject.Features.CQRS.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public GetTestimonialByIdQueryResult Handle(GetTestimonialByIdQuery getTestimonialByIdQuery)
        {
            var value = _repository.GetByID(getTestimonialByIdQuery.ID);

            GetTestimonialByIdQueryResult result = new GetTestimonialByIdQueryResult();

            result.TestimonialID = value.TestimonialID;
            result.ImageUrl = value.ImageUrl;
            result.Comment = value.Comment;
            result.Country = value.Country;
            result.NameSurname = value.NameSurname;

            return result;

        } 
    }
}
//public int TestimonialID { get; set; }
//public string ImageUrl { get; set; }
//public string Comment { get; set; }
//public string NameSurname { get; set; }
//public string Country { get; set; }