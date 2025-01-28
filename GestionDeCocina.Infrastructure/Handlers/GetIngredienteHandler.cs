using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Application.Ingredientes.createIngrediente.GetIngrediente;
using GestionDeCocina.Infrastructure.StoredModel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GestionDeCocina.Infrastructure.Handlers
{
    internal class GetItemsHandler : IRequestHandler<GetIngredienteQuery, IEnumerable<IngredienteDto>>
    {
        private readonly StoredDbContext _dbContext;

        public GetItemsHandler(StoredDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<IngredienteDto>> Handle(GetIngredienteQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Ingrediente.AsNoTracking().
                Select(i => new IngredienteDto()
                {
                    Id = i.Id,
                    IngredienteName = i.IngredienteName
                }).
                ToListAsync(cancellationToken);
        }
    }
}
