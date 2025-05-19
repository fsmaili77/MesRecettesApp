namespace MesRecettes.Models
{
    public class Recette
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public SystemeDeMesure SystemeDeMesure { get; set; }
        public int? TemperatureDeCuisson { get; set; }
        public int? TempsDeCuisson { get; set; }
        public string Instructions { get; set; }
        public int TypeAlimentId { get; set; }
        public int OrigineAlimentId { get; set; }

        public virtual TypeAliment TypeAliment { get; set; }
        public virtual OrigineAliment OrigineAliment { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set;}
        public virtual ICollection<IngredientRecette> RecetteIngredients { get; set; }
    }

}
