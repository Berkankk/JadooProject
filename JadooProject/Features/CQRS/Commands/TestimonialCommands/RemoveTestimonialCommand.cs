namespace JadooProject.Features.CQRS.Commands.TestimonialCommands
{
    public class RemoveTestimonialCommand
    {
        public int ID { get; set; }

        public RemoveTestimonialCommand(int iD)
        {
            ID = iD;
        }
    }
}
