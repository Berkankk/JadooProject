using MediatR;

namespace JadooProject.Features.Mediator.Commands.ServiceCommands
{
    public class RemoveServiceCommand : IRequest
    {
        //Küçüktür büyüktür içinde bir şey yazmadık çünkü geriye dönüş değeri içermiyor
        //Sadece id ye göre silme işlemi yapıyoruz
        public int ID { get; set; }

        public RemoveServiceCommand(int iD)
        {
            ID = iD;
        }
    }
}
