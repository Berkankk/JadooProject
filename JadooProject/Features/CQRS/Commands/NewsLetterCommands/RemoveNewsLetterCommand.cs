namespace JadooProject.Features.CQRS.Commands.NewsLetterCommands
{
    public class RemoveNewsLetterCommand
    {
        public int ID { get; set; }

        public RemoveNewsLetterCommand(int iD)
        {
            ID = iD;
        }
    }
}
