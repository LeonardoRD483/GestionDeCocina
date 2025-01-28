using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Application.Ingredientes.createIngrediente.GetIngrediente;
using MediatR;

namespace GestionDeCocina.Application.Receta.createReceta.GetReceta
{
    public record GetRecetaQuery() : IRequest<List<RecetaDto>>;

}
