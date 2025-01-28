using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using GestionDeCocina.Domain.abstractions;

namespace GestionDeCocina.Domain.RecetaAndIngredientes
{

    public class PaqueteAndReceta : AggregateRoot
    {

        public Guid paquete { get; private set; }
        public Guid receta { get; private set; }
        public PaqueteAndReceta(Guid id, Guid paquete, Guid receta)
        {
            this.paquete = paquete;
            this.receta = receta;
        }


    }
}