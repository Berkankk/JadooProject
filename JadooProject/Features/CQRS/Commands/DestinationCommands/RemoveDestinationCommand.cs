namespace JadooProject.Features.CQRS.Commands.DestinationCommands
{
    public class RemoveDestinationCommand
    {
        public int ID { get; set; }

        public RemoveDestinationCommand(int iD)
        {
            ID = iD;
        }
    }
}
