using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using GestionDeCocina.Domain.abstractions;

namespace GestionDeCocina.Domain.RecetaAndIngredientes
{

    public class RecetaAndIngredientes : AggregateRoot
    {

        public Guid receta { get; private set; }
        public Guid ingrediente { get; private set; }
        public RecetaAndIngredientes(Guid id, Guid receta, Guid ingrediente)
        {
            this.receta = receta;
            this.ingrediente = ingrediente;
        }


    }
}