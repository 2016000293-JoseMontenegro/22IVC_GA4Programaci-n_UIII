internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: José Montenegro \n" +
           "Grado: IVC - Clave = 22\n" +
           "===GRADOS===");
        Console.Write("Ingrese la temperatura en grados centigrados: ");
        double cel = Convert.ToDouble(Console.ReadLine());

        double fah = (cel * 9 / 5) + 32;
        double kel = cel + 273.15;

        Console.WriteLine();
        Console.WriteLine("Fahrenheit: " + fah.ToString("F2"));
        Console.WriteLine("Celsius: " + cel.ToString("F2"));
        Console.WriteLine("Kelvin: " + kel.ToString("F2"));

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para cerrar...");
        Console.ReadKey();
    }
}