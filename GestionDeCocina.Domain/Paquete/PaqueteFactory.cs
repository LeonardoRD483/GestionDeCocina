using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Recetas;

namespace GestionDeCocina.Domain.Paquete
{
    public class PaqueteFactory : IPaqueteFactory
    {
        Paquete IPaqueteFactory.Create(Guid id, string recetaName)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Id is required", nameof(id));
            }

            if (string.IsNullOrWhiteSpace(recetaName))
            {
                throw new ArgumentException("paquete name is required", nameof(recetaName));
            }

            return new Paquete(id, recetaName);
        }
    }
}
