using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Application.Ingredientes.createIngrediente.GetIngrediente;
using GestionDeCocina.Application.Paquete.createPaquete.GetPaquete;
using GestionDeCocina.Infrastructure.StoredModel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GestionDeCocina.Infrastructure.Handlers
{

    internal class GetPaqueteHandler : IRequestHandler<GetPaqueteQuery, IEnumerable<PaqueteDto>>
    {
        private readonly StoredDbContext _dbContext;

        public GetPaqueteHandler(StoredDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<PaqueteDto>> Handle(GetPaqueteQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Paquete.AsNoTracking().
                Select(i => new PaqueteDto()
                {
                    Id = i.Id,
                    PaqueteName = i.Paquetename
                }).
                ToListAsync(cancellationToken);
        }
    }
}
