using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.Mediator.Commands.ServiceCommands;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.ServiceHandlers
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommand>
    {
        //küçüktür büyüktür içinde requesti yazdık yani kim için
        private readonly JadooContext _context;

        public UpdateServiceCommandHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
        {
            var service = new Service
            {
                ServiceID = request.ServiceID,
                Title = request.Title,
                Icon = request.Icon,
                Description = request.Description
            };
            _context.Update(service);   //Update in asenkron metodu olmadığı için await kullanmadık
            await _context.SaveChangesAsync();

        }
    }
}
