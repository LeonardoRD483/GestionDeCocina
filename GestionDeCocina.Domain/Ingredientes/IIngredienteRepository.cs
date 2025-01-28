using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.abstractions;

namespace GestionDeCocina.Domain.Ingredientes
{
    public interface IIngredienteReposaitory: IRepository<Ingrediente>
    {
    }
}
