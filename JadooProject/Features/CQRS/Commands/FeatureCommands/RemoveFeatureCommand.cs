namespace JadooProject.Features.CQRS.Commands.FeatureCommands
{
    public class RemoveFeatureCommand
    {
        public int ID { get; set; }

        public RemoveFeatureCommand(int iD)
        {
            ID = iD;
        }
    }
}
