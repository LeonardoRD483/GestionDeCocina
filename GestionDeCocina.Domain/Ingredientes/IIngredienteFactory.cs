using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCocina.Domain.Ingredientes
{
    public interface IIngredienteFactory
    {
        Ingrediente Create(Guid id, string ingredienteName);
    }
}
