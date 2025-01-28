using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Ingredientes;
using GestionDeCocina.Domain.Recetas;
using GestionDeCocina.Infrastructure.DomainModel;

namespace GestionDeCocina.Infrastructure.Repositories
{

    internal class RecetaRepository : IRecetaReposaitory
    {

        private readonly DomainDbContext _dbContext;

        public RecetaRepository(DomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Receta entity)
        {
            await _dbContext._recetas.AddAsync(entity);
        }
    }
}
