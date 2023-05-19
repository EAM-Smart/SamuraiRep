    namespace SamuraiApp
{
    public class Samurai
    {
        public string Nombre { get; set; }
        public List<Arma> Armas { get; set; }
        public Caballo Caballo { get; set; }

        public Samurai(string nombre)
        {
            Nombre = nombre;
            Armas = new List<Arma>();
        }

        public bool AgregarArma(string nombre, Letalidad letalidad)
        {
            var arma = new Arma(nombre, letalidad);
            Armas.Add(arma);
            return true;
        }

        public string AtacarConArmas()
        {
            var mensaje = $"El samurai {Nombre} ataca con sus armas:\n";
            foreach (var arma in Armas)
            {
                mensaje += $"{arma.Nombre} ({arma.Letalidad})\n";
            }
            return mensaje;
        }

        public string MontarCaballo()
        {
            if (Caballo != null)
            {
                var mensaje = $"El samurai {Nombre} monta su caballo {Caballo.Nombre}\n";
                mensaje += Caballo.Galopar();
                return mensaje;
            }
            else
            {
                return $"El samurai {Nombre} no tiene un caballo";
            }
        }
    }
}
