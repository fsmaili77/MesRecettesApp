namespace MesRecettes.Models
{
    public class Consultation
    {
        public int Id { get; set; }
        public string Nom { get; set; }
    }

    public enum SystemeDeMesure
    {
        Metrique,
        Imperial
    }
    public enum UniteTemperature
    {
        Celsius,
        Fahrenheit
    }
}
