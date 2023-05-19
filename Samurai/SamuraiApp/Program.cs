
namespace SamuraiApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Samurai samurai = new Samurai("Miyamoto");

            // Agregar armas al samurai
            samurai.AgregarArma("Katana", Letalidad.Alta);
            samurai.AgregarArma("Wakizashi", Letalidad.Media);
            samurai.AgregarArma("Tanto", Letalidad.Baja);

            // Agregar caballo al samurai
            samurai.Caballo = new Caballo("Kage");

            // Menú para manejo del samurai y sus armas
            int opcion = 0;
            while (opcion != 5)
            {
                Console.WriteLine("----- MENÚ -----");
                Console.WriteLine("1. Mostrar armas del samurai");
                Console.WriteLine("2. Atacar con armas");
                Console.WriteLine("3. Montar caballo");
                Console.WriteLine("4. Desmontar caballo");
                Console.WriteLine("5. Salir");
                Console.Write("Ingrese una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"El samurai {samurai.Nombre} tiene las siguientes armas:");
                        foreach (var arma in samurai.Armas)
                        {
                            Console.WriteLine($"{arma.Nombre} ({arma.Letalidad})");
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        samurai.AtacarConArmas();
                        Console.WriteLine();
                        break;
                    case 3:
                        samurai.MontarCaballo();
                        Console.WriteLine();
                        break;
                    case 4:
                        samurai.Caballo = null;
                        Console.WriteLine($"El samurai {samurai.Nombre} ha desmontado el caballo");
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}