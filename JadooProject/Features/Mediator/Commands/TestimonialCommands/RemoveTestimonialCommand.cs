using MediatR;

namespace JadooProject.Features.Mediator.Commands.TestimonialCommands
{
    public class RemoveTestimonialCommand : IRequest
    {
        public int ID { get; set; }

        public RemoveTestimonialCommand(int ıD)
        {
            ID = ıD;
        }
    }
}
