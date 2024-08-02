namespace JadooProject.Features.CQRS.Commands.NewsLetterCommands
{
    public class UpdateNewsLetterCommand
    {
        public int NewsLetterID { get; set; }
        public string Email { get; set; }
    }
}
