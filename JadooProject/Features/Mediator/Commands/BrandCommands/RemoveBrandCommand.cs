using MediatR;

namespace JadooProject.Features.Mediator.Commands.BrandCommands
{
    public class RemoveBrandCommand : IRequest
    {
        public int ID { get; set; }

        public RemoveBrandCommand(int iD)
        {
            ID = iD;
        }
    }
}
