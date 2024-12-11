using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domain.Abstractions;

namespace domain.Ingredientes
{

    public class Ingrediente : AggregateRoot
    {
        public string Name { get; private set; }
        public string UnitOfMeasure { get; private set; }
        public decimal CostPerUnit { get; private set; } 
        public Stock AvailableStock { get; private set; }

        public Ingrediente(Guid id, string name, string unitOfMeasure, decimal costPerUnit, Stock initialStock) : base(id)
        {
            Name = name;
            UnitOfMeasure = unitOfMeasure;
            CostPerUnit = costPerUnit;
            AvailableStock = initialStock;
        }

        public void UpdateCost(decimal newCost)
        {
            if (newCost <= 0)
                throw new ArgumentException("Cost per unit must be greater than zero.");

            CostPerUnit = newCost;
        }
        
        public void UpdateStock(Stock newStock)
        {
            AvailableStock = newStock;
        }

        // Needed for EF Core
        private Ingrediente() { }
    }
}