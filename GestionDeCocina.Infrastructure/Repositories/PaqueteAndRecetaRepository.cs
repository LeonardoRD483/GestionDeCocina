using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.RecetaAndIngredientes;
using GestionDeCocina.Infrastructure.DomainModel;

namespace GestionDeCocina.Infrastructure.Repositories
{
    internal class PaqueteAndRecetaRepository : IPaqueteAndRecetaReposaitory
    {

        private readonly DomainDbContext _dbContext;

        public PaqueteAndRecetaRepository(DomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(PaqueteAndReceta entity)
        {
            await _dbContext._paqueteAndReceta.AddAsync(entity);
        }
    }
}
