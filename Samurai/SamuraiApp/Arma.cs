

    namespace SamuraiApp
{
    public class Arma
    {
        public string Nombre { get; set; }
        public Letalidad Letalidad { get; set; }

        public Arma(string nombre, Letalidad letalidad)
        {
            Nombre = nombre;
            Letalidad = letalidad;
        }

        public string Atacar()
        {
            return $"El samurai ataca con {Nombre} ({Letalidad})";
        }
    }
}
