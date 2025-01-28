using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Recetas;

namespace GestionDeCocina.Domain.RecetaAndIngredientes
{
    public class PaqueteAndRecetaFactory : IPaqueteAndRecetaFactory
    {

        PaqueteAndReceta IPaqueteAndRecetaFactory.Create(Guid id, Guid paquete, Guid receta)
        {
            return new PaqueteAndReceta(id, paquete, receta);
        }
    }
}
