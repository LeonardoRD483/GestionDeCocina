using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GestionDeCocina.Application.PaqueteAndReceta.createPaqueteAndReceta
{
    public record CreatePaqueteAndRecetaCommand(Guid Id, Guid paquete, Guid receta) : IRequest<Guid>;

}
