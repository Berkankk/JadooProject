using MediatR;

namespace JadooProject.Features.Mediator.Commands.DestinationCommands
{
    public class UpdateDestinationCommand : IRequest
    {
        public int DestinationID { get; set; }
        public string ImageUrl { get; set; }
        public string City { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }
    }
}
