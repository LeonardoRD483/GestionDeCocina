using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.Ingredientes;

namespace domain.Recetas
{
    internal class RecetaFactory : IRecetaFactory
    {
        public Receta CreateReceta(Guid id, string name, NutritionInformation nutritionInfo, List<RecipeIngredient> ingredients)
        {

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Recipe name cannot be null or empty.");

            if (nutritionInfo == null)
                throw new ArgumentException("Nutrition information must be provided.");

            if (ingredients == null || ingredients.Count == 0)
                throw new ArgumentException("A recipe must have at least one ingredient.");


            var recipe = new Receta(id, name, nutritionInfo);


            foreach (var ingredient in ingredients)
            {
                recipe.AddOrUpdateIngredient(ingredient);
            }

            return recipe;
        }
    }
    }
