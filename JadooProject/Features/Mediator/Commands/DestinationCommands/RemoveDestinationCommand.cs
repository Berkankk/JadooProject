using MediatR;

namespace JadooProject.Features.Mediator.Commands.DestinationCommands
{
    public class RemoveDestinationCommand : IRequest
    {
        public int ID { get; set; }

        public RemoveDestinationCommand(int iD)
        {
            ID = iD;
        }
    }
}
