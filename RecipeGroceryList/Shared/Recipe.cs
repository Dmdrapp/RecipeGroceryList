namespace RecipeGroceryList.Shared
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public DateTime CreateDate { get; set; }
    }
}