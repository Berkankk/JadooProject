namespace JadooProject.Features.CQRS.Commands.TestimonialCommands
{
    public class UpdateTestimonialCommand
    {
        public int TestimonialID { get; set; }
        public string ImageUrl { get; set; }
        public string Comment { get; set; }
        public string NameSurname { get; set; }
        public string Country { get; set; }
    }
}
