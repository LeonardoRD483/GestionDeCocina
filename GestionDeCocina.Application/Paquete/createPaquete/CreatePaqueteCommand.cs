using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GestionDeCocina.Application.Paquete.createPaquete
{
    public record CreatePaqueteCommand(Guid Id, string paqueteName) : IRequest<Guid>;

}
