using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Ingredientes
{

    public interface IIngredienteRepository
    {

        Task AddAsync(Ingrediente ingredient);


        Task UpdateAsync(Ingrediente ingredient);


        Task DeleteAsync(Guid id);

        Task<Ingrediente> GetByIdAsync(Guid id);

        Task<IReadOnlyList<Ingrediente>> GetAllAsync();
        Task<IReadOnlyList<Ingrediente>> SearchAsync(string searchTerm);

        Task UpdateStockAsync(Guid id, int newStock);
    }
}