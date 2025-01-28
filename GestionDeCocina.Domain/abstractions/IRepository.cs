using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCocina.Domain.abstractions
{
    public interface IRepository<TEntity> where TEntity : AggregateRoot
    {
        Task AddAsync(TEntity entity);
    }
}
