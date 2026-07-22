internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: José Montenegro \n" +
           "Grado: IVC - Clave = 22\n" +
           "===MONEDAS===");
        string respuesta = "s";

        while (respuesta == "s")
        {
            Console.Write("Ingrese la cantidad en quetzales: Q");
            double quetzales = Convert.ToDouble(Console.ReadLine());

            double dolares = quetzales / 7.70;
            double euros = quetzales / 8.40;
            double pesos = quetzales * 2.20;
            double yenes = quetzales * 19.00;
            double colones = quetzales * 66.00;

            Console.WriteLine();
            Console.WriteLine("Dolares: " + dolares.ToString("F2"));
            Console.WriteLine("Euros: " + euros.ToString("F2"));
            Console.WriteLine("Pesos mexicanos: " + pesos.ToString("F2"));
            Console.WriteLine("Yenes: " + yenes.ToString("F2"));
            Console.WriteLine("Colones: " + colones.ToString("F2"));

            Console.WriteLine();
            Console.Write("Desea convertir otra cantidad (s/n): ");
            respuesta = Console.ReadLine().ToLower();
            Console.WriteLine();
        }

        Console.WriteLine("Programa finalizado.");
        Console.WriteLine("Presione una tecla para cerrar...");
        Console.ReadKey();
    }
}