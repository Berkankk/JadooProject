namespace JadooProject.Features.CQRS.Commands.BrandCommands
{
    public class RemoveBrandCommand
    {
        public int ID { get; set; }

        public RemoveBrandCommand(int iD)
        {
            ID = iD;
        }
    }
}
