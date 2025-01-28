using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Recetas;

namespace GestionDeCocina.Domain.RecetaAndIngredientes
{
    public class RecetaAndIngredienteFactory : IRecetaAndIngredientesFactory
    {

        RecetaAndIngredientes IRecetaAndIngredientesFactory.Create(Guid id, Guid receta, Guid ingrediente)
        {
            return new RecetaAndIngredientes(id, receta, ingrediente);
        }
    }
}
