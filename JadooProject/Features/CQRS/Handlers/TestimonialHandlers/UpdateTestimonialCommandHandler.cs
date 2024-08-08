using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.TestimonialCommands;

namespace JadooProject.Features.CQRS.Handlers.TestimonialHandlers
{
    public class UpdateTestimonialCommandHandler
    {
        private readonly IRepository<Testimonial> _repository;

        public UpdateTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public void Handle(UpdateTestimonialCommand command)
        {
            var updateTesti = new Testimonial
            {
                TestimonialID = command.TestimonialID,
                Comment = command.Comment,
                Country = command.Country,
                ImageUrl = command.ImageUrl,
                NameSurname = command.NameSurname
            };
            _repository.Update(updateTesti);
        }
    }
}
//public int TestimonialID { get; set; }
//public string ImageUrl { get; set; }
//public string Comment { get; set; }
//public string NameSurname { get; set; }
//public string Country { get; set; }