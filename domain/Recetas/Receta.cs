using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domain.Abstractions;

namespace domain.Recetas
{

    public class Receta : AggregateRoot
    {
        public string Name { get; private set; }
        public List<RecipeIngredient> Ingredients { get; private set; }
        public NutritionInformation NutritionInfo { get; private set; }

        public Receta(Guid id, string name, string descripcion, NutritionInformation nutritionInfo) : base(id)
        {
            Name = name;
            Ingredients = new List<RecipeIngredient>();
            NutritionInfo = nutritionInfo;
        }

        public void AddOrUpdateIngredient(RecipeIngredient ingredient)
        {
            var existingIngredient = Ingredients.Find(i => i.IngredientId == ingredient.IngredientId);
            if (existingIngredient != null)
            {
                existingIngredient.UpdateQuantity(ingredient.Quantity);
            }
            else
            {
                Ingredients.Add(ingredient);
            }
        }

        public void RemoveIngredient(Guid ingredientId)
        {
            Ingredients.RemoveAll(i => i.IngredientId == ingredientId);
        }

        // Need for EF Core
        private Receta() { }

        public Receta(Guid id, string name, NutritionInformation nutritionInfo) : base(id)
        {
        }
    }

    public class RecipeIngredient
    {
        public Guid IngredientId { get; private set; }
        public int Quantity { get; private set; }

        public RecipeIngredient(Guid ingredientId, int quantity)
        {
            IngredientId = ingredientId;
            Quantity = quantity;
        }

        public void UpdateQuantity(int newQuantity)
        {
            Quantity = newQuantity;
        }
    }

    public class NutritionInformation
    {
        public decimal Calories { get; private set; }
        public decimal Proteins { get; private set; }
        public decimal Carbohydrates { get; private set; }
        public decimal Fats { get; private set; }

        public NutritionInformation(decimal calories, decimal proteins, decimal carbohydrates, decimal fats)
        {
            Calories = calories;
            Proteins = proteins;
            Carbohydrates = carbohydrates;
            Fats = fats;
        }
    }

}
