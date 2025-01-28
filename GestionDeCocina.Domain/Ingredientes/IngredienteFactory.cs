using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCocina.Domain.Ingredientes
{
    public class IngredienteFactory : IIngredienteFactory
    {
        Ingrediente IIngredienteFactory.Create(Guid id, string ingredienteName)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Id is required", nameof(id));
            }

            if (string.IsNullOrWhiteSpace(ingredienteName))
            {
                throw new ArgumentException("Ingrediente name is required", nameof(ingredienteName));
            }

            return new Ingrediente(id, ingredienteName);
        }
    }
}
