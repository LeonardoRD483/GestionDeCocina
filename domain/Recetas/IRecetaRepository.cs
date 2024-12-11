using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Recetas
{
    public interface IRecetaRepository
    {
        Task AddAsync(Receta recipe);

        Task UpdateAsync(Receta recipe);

        Task DeleteAsync(Guid id);

        Task<Receta> GetByIdAsync(Guid id);

        Task<IReadOnlyList<Receta>> GetAllAsync();

        Task<IReadOnlyList<Receta>> SearchAsync(string searchTerm);
    }
}