using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Application.Receta.createReceta.GetReceta;
using GestionDeCocina.Application.RecetaAndIngredientes.createRecetaAndIngredientes.GetRecetaAndIngredientes;
using GestionDeCocina.Infrastructure.StoredModel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GestionDeCocina.Infrastructure.Handlers
{

    internal class GetRecetaAndIngredientesHandler : IRequestHandler<GetRecetaAndIngredienteQuery, IEnumerable<RecetaAndIngredienteDto>>
    {
        private readonly StoredDbContext _dbContext;

        public GetRecetaAndIngredientesHandler(StoredDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<RecetaAndIngredienteDto>> Handle(GetRecetaAndIngredienteQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.RecetaAndIngredientes.AsNoTracking().
                Select(i => new RecetaAndIngredienteDto()
                {
                    Id = i.Id,
                    Receta = i.receta,
                    Ingrediente = i.ingrediente,
                }).
                ToListAsync(cancellationToken);
        }
    }
}
