using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Application.Ingredientes.createIngrediente;
using GestionDeCocina.Domain.abstractions;
using GestionDeCocina.Domain.Ingredientes;
using GestionDeCocina.Domain.Paquete;
using MediatR;

namespace GestionDeCocina.Application.Paquete.createPaquete
{

    internal class CreateCommandHandler : IRequestHandler<CreatePaqueteCommand, Guid>

    {

        private readonly IPaqueteFactory _paqueteFactory;
        private readonly IPaqueteRepository _paqueteRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCommandHandler(IPaqueteFactory paqueteFactory, IPaqueteRepository paqueteRepository, IUnitOfWork unitOfWork)
        {
            _paqueteFactory = paqueteFactory;
            _paqueteRepository = paqueteRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreatePaqueteCommand request, CancellationToken cancellationToken)
        {
            var paquete = _paqueteFactory.Create(request.Id, request.paqueteName);
            await _paqueteRepository.AddAsync(paquete);
            paquete.Complete();
            await _unitOfWork.CommitAsync(cancellationToken);
            return request.Id;
        }
    }
}
