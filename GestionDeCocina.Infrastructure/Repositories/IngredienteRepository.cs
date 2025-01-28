using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Ingredientes;
using GestionDeCocina.Infrastructure.DomainModel;

namespace GestionDeCocina.Infrastructure.Repositories
{
    internal class IngredienteRepository : IIngredienteReposaitory
    {

        private readonly DomainDbContext _dbContext;

        public IngredienteRepository(DomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Ingrediente entity)
        {
            await _dbContext._ingredientes.AddAsync(entity);
        }
    }
}
