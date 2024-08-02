namespace JadooProject.Features.CQRS.Commands.ManuelCommands
{
    public class RemoveManuelCommand
    {
        public int ID { get; set; }

        public RemoveManuelCommand(int iD)
        {
            ID = iD;
        }
    }
}
