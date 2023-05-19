    namespace SamuraiApp
{
    public class Caballo
    {
        public string Nombre { get; set; }

        public Caballo(string nombre)
        {
            Nombre = nombre;
        }

        public string Galopar()
        {
            return $"El samurai monta su caballo {Nombre} y galopa velozmente";
        }
    }
}