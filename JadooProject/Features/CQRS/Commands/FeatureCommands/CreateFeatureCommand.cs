namespace JadooProject.Features.CQRS.Commands.FeatureCommands
{
    public class CreateFeatureCommand
    {
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }
        public string LowerDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}
