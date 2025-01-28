using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.abstractions;

namespace GestionDeCocina.Domain.Recetas
{
    public class Receta: AggregateRoot
    {

        public string Name { get; private set; }

        public Receta(Guid id, string name)
        {
            Name = name;
        }

    }
}
