using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Recetas;

namespace GestionDeCocina.Domain.RecetaAndIngredientes
{

    public interface IRecetaAndIngredientesFactory
    {
        RecetaAndIngredientes Create(Guid id, Guid Receta, Guid Ingrediente);

    }
}
