using RecipeGroceryList.Shared.Enums;

namespace RecipeGroceryList.Shared
{
    public class RecipeIngredient
    {
        public Ingredient Ingredient { get; set; }
        public decimal Quantity { get; set; }
        public Weight? Weight { get; set; }
        public Volume? Volume { get; set; }
        public DateTime CreateDate { get; set; }

        public RecipeIngredient (Ingredient ingredient, decimal quantity, Weight? weight, Volume? volume)
        {
            Ingredient = ingredient;
            Quantity = quantity;
            Weight = weight;
            Volume = volume;
            CreateDate = DateTime.Now;
        }
    }
}