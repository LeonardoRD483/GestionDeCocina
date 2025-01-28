using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GestionDeCocina.Application.Ingredientes.createIngrediente.GetIngrediente;

public record GetIngredienteQuery(): IRequest<List<IngredienteDto>>;
