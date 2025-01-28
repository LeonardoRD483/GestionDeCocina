using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Ingredientes;
using GestionDeCocina.Domain.RecetaAndIngredientes;
using GestionDeCocina.Domain.Recetas;
using GestionDeCocina.Infrastructure.DomainModel;

namespace GestionDeCocina.Infrastructure.Repositories
{

    internal class RecetaAndIngredienteRepository : IRecetaAndIngredienteReposaitory
    {

        private readonly DomainDbContext _dbContext;

        public RecetaAndIngredienteRepository(DomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(RecetaAndIngredientes entity)
        {
            await _dbContext._recetaAndIngredientes.AddAsync(entity);
        }
    }
}
