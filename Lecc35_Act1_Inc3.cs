internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: José Montenegro \n" +
           "Grado: IVC - Clave = 22\n" +
           "===JUEGO===");
        Random aleatorio = new Random();
        string respuesta = "s";

        while (respuesta == "s")
        {
            Console.WriteLine("1. Piedra");
            Console.WriteLine("2. Papel");
            Console.WriteLine("3. Tijeras");
            Console.Write("Seleccione una opcion: ");
            int usuario = Convert.ToInt32(Console.ReadLine());

            if (usuario < 1 || usuario > 3)
            {
                Console.WriteLine("Opcion invalida.");
                Console.ReadKey();
                return;
            }

            int computadora = aleatorio.Next(1, 4);
            string[] opciones = { "", "Piedra", "Papel", "Tijeras" };

            Console.WriteLine();
            Console.WriteLine("Usuario: " + opciones[usuario]);
            Console.WriteLine("Computadora: " + opciones[computadora]);

            if (usuario == computadora)
            {
                Console.WriteLine("Resultado: Empate.");
            }
            else if ((usuario == 1 && computadora == 3) ||
                     (usuario == 2 && computadora == 1) ||
                     (usuario == 3 && computadora == 2))
            {
                Console.WriteLine("Resultado: Usted gano.");
            }
            else
            {
                Console.WriteLine("Resultado: Gano la computadora.");
            }

            Console.WriteLine();
            Console.Write("Desea jugar otra vez (s/n): ");
            respuesta = Console.ReadLine().ToLower();
            Console.WriteLine();
        }

        Console.WriteLine("Juego terminado.");
        Console.WriteLine("Presione una tecla para cerrar...");
        Console.ReadKey();
    }
}