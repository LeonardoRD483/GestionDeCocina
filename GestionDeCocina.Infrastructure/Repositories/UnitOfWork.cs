using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.abstractions;
using GestionDeCocina.Infrastructure.DomainModel;

namespace GestionDeCocina.Infrastructure.Repositories
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DomainDbContext _domainDbContext;

        public UnitOfWork(DomainDbContext domainDbContext)
        {
            _domainDbContext = domainDbContext;
        }

        public async Task CommitAsync(CancellationToken cancellationToke = default)
        {
           await _domainDbContext.SaveChangesAsync(cancellationToke);
        }
    }
}
