using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Recetas;

namespace GestionDeCocina.Domain.Paquete
{

    public interface IPaqueteFactory
    {
        Paquete Create(Guid id, string paqueteName);

    }
}
