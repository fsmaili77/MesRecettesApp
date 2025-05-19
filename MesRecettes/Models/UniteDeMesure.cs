namespace MesRecettes.Models
{
    public class UniteDeMesure : Consultation
    {
        // constructeur par défaut ainsi qu’un constructeur qui prend comme argument une valeur SystemeDeMesure
        public UniteDeMesure() : base()
        {
        }
        public UniteDeMesure(SystemeDeMesure s) : base()
        {
           this.SystemeDeMesure = s;
        }
        public SystemeDeMesure SystemeDeMesure { get; set; }
    }
}
