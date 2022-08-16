namespace RecipeGroceryList.Shared
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RecipeIngredient> RecipeIngredients { get; set; }
        public DateTime CreateDate { get; set; }
    }
}