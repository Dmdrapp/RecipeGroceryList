namespace RecipeGroceryList.Shared
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public Enum Measurement { get; set; }
        public DateTime CreateDate { get; set; }
    }
}