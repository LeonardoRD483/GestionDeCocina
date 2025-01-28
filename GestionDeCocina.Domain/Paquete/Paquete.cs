using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using GestionDeCocina.Domain.abstractions;
using GestionDeCocina.Domain.Paquete.NewFolder;

namespace GestionDeCocina.Domain.Paquete
{

    public class Paquete : AggregateRoot
    {

        public string Name { get; private set; }

        public Paquete(Guid id, string name)
        {
            Name = name;
        }

        public void Complete()
        {   

            AddDomainEvent(new PaqueteCompleted(Id));
        }
    }
    }

