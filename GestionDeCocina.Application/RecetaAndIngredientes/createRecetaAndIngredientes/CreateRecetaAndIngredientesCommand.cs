using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GestionDeCocina.Application.RecetaAndIngredientes.createRecetaAndIngredientes
{
    public record CreateRecetaAndIngredientesCommand(Guid Id, Guid receta, Guid ingrediente) : IRequest<Guid>;

}
