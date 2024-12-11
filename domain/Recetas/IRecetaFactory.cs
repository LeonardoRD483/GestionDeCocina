using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.Ingredientes;

namespace domain.Recetas
{

    public interface IRecetaFactory
    {

        Receta CreateReceta(
            Guid id,
            string name,
            NutritionInformation nutritionInfo,
            List<RecipeIngredient> ingredients);
    }
}