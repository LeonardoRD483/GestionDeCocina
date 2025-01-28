using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCocina.Domain.abstractions
{
    public interface IUnitOfWork
    {
        Task CommitAsync(CancellationToken cancellationToke = default);
    }
}
