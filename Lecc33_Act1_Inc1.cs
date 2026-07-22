internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: José Montenegro \n" +
           "Grado: IVC - Clave = 22\n" +
           "===AGENDA TELEFÓNICA===");
        string[] nombre = new string[10];
        string[] telefono = new string[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Persona " + (i + 1));

            Console.Write("Nombre: ");
            nombre[i] = Console.ReadLine();

            Console.Write("Telefono: ");
            telefono[i] = Console.ReadLine();
        }

        Console.WriteLine();
        Console.Write("Ingrese una posicion del 1 al 10: ");
        int posicion = Convert.ToInt32(Console.ReadLine());

        if (posicion >= 1 && posicion <= 10)
        {
            int indice = posicion - 1;
            Console.WriteLine();
            Console.WriteLine("Nombre: " + nombre[indice]);
            Console.WriteLine("Telefono: " + telefono[indice]);
        }
        else
        {
            Console.WriteLine("Posicion invalida.");
        }

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para cerrar...");
        Console.ReadKey();
    }
}