using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Application.Ingredientes.createIngrediente.GetIngrediente;
using GestionDeCocina.Application.Receta.createReceta.GetReceta;
using GestionDeCocina.Infrastructure.StoredModel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GestionDeCocina.Infrastructure.Handlers
{

    internal class GetRecetaHandler : IRequestHandler<GetRecetaQuery, IEnumerable<RecetaDto>>
    {
        private readonly StoredDbContext _dbContext;

        public GetRecetaHandler(StoredDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<RecetaDto>> Handle(GetRecetaQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Receta.AsNoTracking().
                Select(i => new RecetaDto()
                {
                    Id = i.Id,
                    RecetaName = i.recetaName
                }).
                ToListAsync(cancellationToken);
        }
    }
}
