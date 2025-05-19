namespace MesRecettes.Models
{
    public class IngredientRecette
    {
        public int RecetteId { get; set; }
        public int IngredientId { get; set; }
        public virtual Recette Recette { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}
