using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.TestimonialCommands;

namespace JadooProject.Features.CQRS.Handlers.TestimonialHandlers
{
    public class RemoveTestimonialCommandHandler
    {
        private readonly IRepository<Testimonial> _repository;

        public RemoveTestimonialCommandHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public void Handle (RemoveTestimonialCommand command)
        {
            _repository.Delete(command.ID);
        } 
    }
}
