using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Application.Ingredientes.createIngrediente;
using GestionDeCocina.Domain.abstractions;
using GestionDeCocina.Domain.Ingredientes;
using GestionDeCocina.Domain.Recetas;
using MediatR;

namespace GestionDeCocina.Application.Receta.createReceta
{

    internal class CreateCommandHandler : IRequestHandler<CreateRecetaCommand, Guid>

    {

        private readonly IRecetaFactory _recetaFactory;
        private readonly IRecetaReposaitory _recetaReposaitory;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCommandHandler(IRecetaFactory recetaFactory, IRecetaReposaitory recetaReposaitory, IUnitOfWork unitOfWork)
        {
            _recetaFactory = recetaFactory;
            _recetaReposaitory = recetaReposaitory;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateRecetaCommand request, CancellationToken cancellationToken)
        {
            var ingrediente = _recetaFactory.Create(request.Id, request.RecetaName);
            await _recetaReposaitory.AddAsync(ingrediente);
            await _unitOfWork.CommitAsync(cancellationToken);
            return request.Id;
        }
    }
}
