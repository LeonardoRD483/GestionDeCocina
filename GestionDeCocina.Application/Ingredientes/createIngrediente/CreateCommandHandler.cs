using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.abstractions;
using GestionDeCocina.Domain.Ingredientes;
using MediatR;

namespace GestionDeCocina.Application.Ingredientes.createIngrediente
{
    internal class CreateCommandHandler : IRequestHandler<CreateIngredienteCommand, Guid>

    {

        private readonly IIngredienteFactory _ingredienteFactory;
        private readonly IIngredienteReposaitory _ingredienteRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCommandHandler(IIngredienteFactory ingredienteFactory, IIngredienteReposaitory ingredienteRepository, IUnitOfWork unitOfWork)
        {
            _ingredienteFactory = ingredienteFactory;
            _ingredienteRepository = ingredienteRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateIngredienteCommand request, CancellationToken cancellationToken)
        {
            var ingrediente = _ingredienteFactory.Create(request.Id, request.IngredienteName);
            await _ingredienteRepository.AddAsync(ingrediente);
            await _unitOfWork.CommitAsync(cancellationToken);
            return request.Id;    
           }
    }
}
