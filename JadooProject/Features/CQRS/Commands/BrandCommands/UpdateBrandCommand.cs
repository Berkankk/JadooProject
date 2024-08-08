namespace JadooProject.Features.CQRS.Commands.BrandCommands
{
    public class UpdateBrandCommand
    {
        public int BrandID { get; set; }  //Marka id si
        public string ImageUrl { get; set; }
        public IFormFile File { get; set; }
    }
}
