 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Ingredientes;

namespace GestionDeCocina.Domain.Recetas
{
    public  class RecetaFactory : IRecetaFactory
    {
        Receta IRecetaFactory.Create(Guid id, string recetaName)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Id is required", nameof(id));
            }

            if (string.IsNullOrWhiteSpace(recetaName))
            {
                throw new ArgumentException("receta name is required", nameof(recetaName));
            }

            return new Receta(id, recetaName);
        }
    }
}
