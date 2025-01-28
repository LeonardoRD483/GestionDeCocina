using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCocina.Application.RecetaAndIngredientes.createRecetaAndIngredientes.GetRecetaAndIngredientes
{
    public class RecetaAndIngredienteDto
    {
        public Guid Id { get; set; }
        public Guid Receta { get; set; }
        public Guid Ingrediente { get; set; }
    }
}
