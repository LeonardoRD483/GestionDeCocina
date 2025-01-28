using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.abstractions;

namespace GestionDeCocina.Domain.Paquete.NewFolder
{
    public record PaqueteCompleted : DomainEvent
    {
        public Guid PaqueteId { get; init; }


        public PaqueteCompleted(Guid paqueteId)
        {
            PaqueteId = paqueteId;
        }

    }
}
