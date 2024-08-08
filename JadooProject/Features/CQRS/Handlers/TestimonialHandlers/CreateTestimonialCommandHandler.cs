using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.TestimonialCommands;

namespace JadooProject.Features.CQRS.Handlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler
    {
        private readonly IRepository<Testimonial> _repository;

        public CreateTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public void Handle(CreateTestimonialCommand command)
        {
            var testimonial = new Testimonial
            {
                ImageUrl = command.ImageUrl,
                Comment = command.Comment,
                NameSurname = command.NameSurname,
                Country = command.Country
            };
            _repository.Create(testimonial);
        }
    }
}
//public int TestimonialID { get; set; }
//public string ImageUrl { get; set; }
//public string Comment { get; set; }
//public string NameSurname { get; set; }
//public string Country { get; set; }