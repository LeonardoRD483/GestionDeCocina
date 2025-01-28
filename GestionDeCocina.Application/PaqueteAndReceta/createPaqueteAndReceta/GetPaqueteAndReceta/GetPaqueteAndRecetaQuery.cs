using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Application.RecetaAndIngredientes.createRecetaAndIngredientes.GetRecetaAndIngredientes;
using MediatR;

namespace GestionDeCocina.Application.PaqueteAndReceta.createPaqueteAndReceta.GetPaqueteAndReceta
{
    public record GetPaqueteAndRecetaQuery() : IRequest<List<PaqueteAndRecetaDto>>;

}
