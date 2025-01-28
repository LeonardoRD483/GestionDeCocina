using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Application.Ingredientes.createIngrediente;
using GestionDeCocina.Application.Receta.createReceta;
using GestionDeCocina.Domain.abstractions;
using GestionDeCocina.Domain.RecetaAndIngredientes;
using GestionDeCocina.Domain.Recetas;
using MediatR;

namespace GestionDeCocina.Application.RecetaAndIngredientes.createRecetaAndIngredientes
{

    internal class CreateCommandHandler : IRequestHandler<CreateRecetaAndIngredientesCommand, Guid>

    {

        private readonly IRecetaAndIngredientesFactory _recetaFactory;
        private readonly IRecetaAndIngredienteReposaitory _recetaReposaitory;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCommandHandler(IRecetaAndIngredientesFactory recetaFactory, IRecetaAndIngredienteReposaitory recetaReposaitory, IUnitOfWork unitOfWork)
        {
            _recetaFactory = recetaFactory;
            _recetaReposaitory = recetaReposaitory;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateRecetaAndIngredientesCommand request, CancellationToken cancellationToken)
        {
            var ingrediente = _recetaFactory.Create(request.Id, request.receta, request.ingrediente);
            await _recetaReposaitory.AddAsync(ingrediente);
            await _unitOfWork.CommitAsync(cancellationToken);
            return request.Id;
        }
    }
}
