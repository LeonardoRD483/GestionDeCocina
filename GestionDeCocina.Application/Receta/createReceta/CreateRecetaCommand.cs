﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GestionDeCocina.Application.Receta.createReceta
{

    public record CreateRecetaCommand(Guid Id, string RecetaName) : IRequest<Guid>;

}
