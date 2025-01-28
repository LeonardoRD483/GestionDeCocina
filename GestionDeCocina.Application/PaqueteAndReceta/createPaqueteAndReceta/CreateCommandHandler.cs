using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Application.RecetaAndIngredientes.createRecetaAndIngredientes;
using GestionDeCocina.Domain.abstractions;
using GestionDeCocina.Domain.RecetaAndIngredientes;
using MediatR;

namespace GestionDeCocina.Application.PaqueteAndReceta.createPaqueteAndReceta
{
    internal class CreateCommandHandler : IRequestHandler<CreatePaqueteAndRecetaCommand, Guid>

    {

        private readonly IPaqueteAndRecetaFactory _paqueteFactory;
        private readonly IPaqueteAndRecetaReposaitory _paqueteReposaitory;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCommandHandler(IPaqueteAndRecetaFactory paqueteFactory, IPaqueteAndRecetaReposaitory paqueteReposaitory, IUnitOfWork unitOfWork)
        {
            _paqueteFactory = paqueteFactory;
            _paqueteReposaitory = paqueteReposaitory;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreatePaqueteAndRecetaCommand request, CancellationToken cancellationToken)
        {
            var paqueteAndReceta = _paqueteFactory.Create(request.Id, request.paquete, request.receta);
            await _paqueteReposaitory.AddAsync(paqueteAndReceta);
            await _unitOfWork.CommitAsync(cancellationToken);
            return request.Id;
        }
    }
}
