namespace Recipe.Models
{
  public class TagRecipe
  {       
    public int TagRecipeId { get; set; }
    public int RecipeId { get; set; }
    public int TagId { get; set; }
    public virtual Recipe Recipe { get; set; }
    public virtual Tag Tag { get; set; }
  }
}