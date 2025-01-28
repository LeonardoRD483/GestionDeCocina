using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCocina.Application.PaqueteAndReceta.createPaqueteAndReceta.GetPaqueteAndReceta
{

    public class PaqueteAndRecetaDto
    {
        public Guid Id { get; set; }
        public Guid Paquete { get; set; }
        public Guid Receta { get; set; }
    }
}
