using MediatR;

namespace JadooProject.Features.Mediator.Commands.BrandCommands
{
    public class UpdateBrandCommand : IRequest
    {
        public int BrandID { get; set; }  //Marka id si
        public string ImageUrl { get; set; }
    }
}
