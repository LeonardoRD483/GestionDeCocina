using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Ingredientes;

namespace GestionDeCocina.Domain.Recetas
{
    public interface IRecetaFactory
    {
        Receta Create(Guid id, string recetaName);

    }
}
