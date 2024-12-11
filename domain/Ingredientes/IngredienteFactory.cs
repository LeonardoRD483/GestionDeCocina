using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Ingredientes
{
    public class IngredientesFactory : IIngredientesFactory
    {
        public Ingrediente CreateIngredient(
            Guid id,
            string name,
            string unitOfMeasure,
            decimal costPerUnit,
            int initialStock)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Ingredient name cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(unitOfMeasure))
                throw new ArgumentException("Unit of measure cannot be null or empty.");

            if (costPerUnit <= 0)
                throw new ArgumentException("Cost per unit must be greater than zero.");

            if (initialStock < 0)
                throw new ArgumentException("Initial stock cannot be negative.");

            return new Ingrediente(id, name, unitOfMeasure, costPerUnit, initialStock);
        }
    }
}