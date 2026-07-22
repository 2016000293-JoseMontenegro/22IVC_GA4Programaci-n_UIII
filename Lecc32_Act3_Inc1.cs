internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: José Montenegro \n" +
           "Grado: IVC - Clave = 22\n" +
           "===TRIÁNGULOS===");
        Console.Write("Ingrese la primera medida: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la segunda medida: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la tercera medida: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();

        if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0 ||
            lado1 + lado2 <= lado3 ||
            lado1 + lado3 <= lado2 ||
            lado2 + lado3 <= lado1)
        {
            Console.WriteLine("Medidas inválidas");
        }
        else if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("El triangulo es equilatero.");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("El triangulo es isosceles.");
        }
        else
        {
            Console.WriteLine("El triangulo es escaleno.");
        }

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para cerrar...");
        Console.ReadKey();
    }
}