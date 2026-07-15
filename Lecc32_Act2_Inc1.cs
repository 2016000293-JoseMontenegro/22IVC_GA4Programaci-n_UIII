internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: José Montenegro \n" +
           "Grado: IVC - Clave = 22\n" +
           "===CALCULADORA DE CAMBIO===");
        int pago;
        string producto;
        Console.WriteLine("\nEscriba el nombre del producto: ");
        producto = Console.ReadLine();
        Console.Write("Dame el precio del producto: ");
        int precio = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite el valor del billete: ");
        pago = Convert.ToInt32(Console.ReadLine());
        int cambio = pago - precio;
        Console.WriteLine("Su cambio es: " + cambio);

    }
}