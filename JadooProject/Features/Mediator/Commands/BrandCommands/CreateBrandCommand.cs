using MediatR;

namespace JadooProject.Features.Mediator.Commands.BrandCommands
{
    public class CreateBrandCommand : IRequest
    {
       
        public string ImageUrl { get; set; }
    }
}
