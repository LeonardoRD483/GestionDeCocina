using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.abstractions;
using GestionDeCocina.Domain.Paquete;
using GestionDeCocina.Domain.Paquete.NewFolder;
using MediatR;

namespace GestionDeCocina.Application.Paquete.EventHandler
{

    internal class CreatePaqueteCompleted : INotificationHandler<PaqueteCompleted>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreatePaqueteCompleted(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(PaqueteCompleted domainEvent, CancellationToken cancellationToken)
        {
            Console.WriteLine("se registra un paquete Completado");
            await _unitOfWork.CommitAsync(cancellationToken);

        }
    }
}
