namespace JadooProject.Features.CQRS.Commands.BrandCommands
{
    public class CreateBrandCommand
    {
   
        public string ImageUrl { get; set; }

        public IFormFile File { get; set; }
    }
}
