using MediatR;

namespace JadooProject.Features.Mediator.Commands.ServiceCommands
{
    public class CreateServiceCommand : IRequest
    {
        //Veritabanında değişiklik yapabildiğimiz işlemleri command klasöründe tutuyoruz
        //Geriye değer döndürmediği için küçüktür büyüktür içinde bir şey yazmayacağız
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
