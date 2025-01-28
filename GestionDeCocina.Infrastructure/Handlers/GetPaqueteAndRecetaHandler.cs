using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Application.PaqueteAndReceta.createPaqueteAndReceta.GetPaqueteAndReceta;
using GestionDeCocina.Application.RecetaAndIngredientes.createRecetaAndIngredientes.GetRecetaAndIngredientes;
using GestionDeCocina.Infrastructure.StoredModel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GestionDeCocina.Infrastructure.Handlers
{

    internal class GetPaqueteAndRecetaHandler : IRequestHandler<GetPaqueteAndRecetaQuery, IEnumerable<PaqueteAndRecetaDto>>
    {
        private readonly StoredDbContext _dbContext;

        public GetPaqueteAndRecetaHandler(StoredDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<PaqueteAndRecetaDto>> Handle(GetPaqueteAndRecetaQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.PaqueteAndReceta.AsNoTracking().
                Select(i => new PaqueteAndRecetaDto()
                {
                    Id = i.Id,
                    Paquete = i.paquete,
                    Receta = i.receta,
                }).
                ToListAsync(cancellationToken);
        }
    }
}
