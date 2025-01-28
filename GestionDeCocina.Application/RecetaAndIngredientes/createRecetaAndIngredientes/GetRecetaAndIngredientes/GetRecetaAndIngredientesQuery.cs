using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Application.Receta.createReceta.GetReceta;
using MediatR;

namespace GestionDeCocina.Application.RecetaAndIngredientes.createRecetaAndIngredientes.GetRecetaAndIngredientes
{
    public record GetRecetaAndIngredienteQuery() : IRequest<List<RecetaAndIngredienteDto>>;

}
