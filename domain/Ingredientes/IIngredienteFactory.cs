using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Ingredientes
{
    public interface IIngredientesFactory
    {

        Ingrediente CreateIngredient(
            Guid id,
            string name,
            string unitOfMeasure,
            decimal costPerUnit,
            int initialStock);
    }
}