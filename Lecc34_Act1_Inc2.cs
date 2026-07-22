internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: José Montenegro \n" +
           "Grado: IVC - Clave = 22\n" +
           "===MASA CORPORAL===");
        Console.Write("Ingrese el peso en kilogramos: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la altura en metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        if (peso <= 0 || altura <= 0)
        {
            Console.WriteLine("Los datos deben ser mayores que cero.");
            Console.ReadKey();
            return;
        }

        double imc = peso / (altura * altura);

        Console.WriteLine();
        Console.WriteLine("IMC: " + imc.ToString("F2"));

        if (imc < 18.5)
            Console.WriteLine("Clasificacion: Bajo peso.");
        else if (imc < 25)
            Console.WriteLine("Clasificacion: Peso normal.");
        else if (imc < 30)
            Console.WriteLine("Clasificacion: Sobrepeso.");
        else
            Console.WriteLine("Clasificacion: Obesidad.");

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para cerrar...");
        Console.ReadKey();
    }
}