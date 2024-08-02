using MediatR;

namespace JadooProject.Features.Mediator.Commands.TestimonialCommands
{
    public class CreateTestimonialCommand : IRequest
    {
  
        public string ImageUrl { get; set; }
        public string Comment { get; set; }
        public string NameSurname { get; set; }
        public string Country { get; set; }
    }
}
