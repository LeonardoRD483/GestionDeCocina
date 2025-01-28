using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Recetas;

namespace GestionDeCocina.Domain.RecetaAndIngredientes
{

    public interface IPaqueteAndRecetaFactory
    {
        PaqueteAndReceta Create(Guid id, Guid paquete, Guid receta);

    }
}
