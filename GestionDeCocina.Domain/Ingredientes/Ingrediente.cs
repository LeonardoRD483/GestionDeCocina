using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.abstractions;

namespace GestionDeCocina.Domain.Ingredientes
{
    public class Ingrediente : AggregateRoot
    {
        public string Name { get; private set; }

        public Ingrediente(Guid id, string name) : base(id)
        {
            Name = name;
        }

        public void UpdateCost(decimal newCost)
        {
            if (newCost <= 0)
                throw new ArgumentException("Cost per unit must be greater than zero.");

        }

        public void UpdateStock(Stock newStock)
        {
        }

        // Needed for EF Core
        private Ingrediente() { }
    }
}
