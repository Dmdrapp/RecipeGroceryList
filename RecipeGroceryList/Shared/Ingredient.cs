using RecipeGroceryList.Shared.Enums;

namespace RecipeGroceryList.Shared
{
    public class Ingredient
    {
        public string Name { get; set; }
        public FoodType Type { get; set; }
        public DateTime CreateDate { get; set; }

        public Ingredient(string name, FoodType foodType)
        {
            Name = name;
            Type = foodType;
            CreateDate = DateTime.Now;
        }
    }

    
}