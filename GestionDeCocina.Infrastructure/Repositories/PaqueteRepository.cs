using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Ingredientes;
using GestionDeCocina.Domain.Paquete;
using GestionDeCocina.Infrastructure.DomainModel;

namespace GestionDeCocina.Infrastructure.Repositories
{

    internal class PaqueteRepository : IPaqueteRepository
    {

        private readonly DomainDbContext _dbContext;

        public PaqueteRepository(DomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Paquete entity)
        {
            await _dbContext._paquete.AddAsync(entity);
        }
    }
}
