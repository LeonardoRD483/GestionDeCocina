using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GestionDeCocina.Application.Ingredientes.createIngrediente
{
    public record CreateIngredienteCommand(Guid Id, string IngredienteName): IRequest<Guid>;
}
