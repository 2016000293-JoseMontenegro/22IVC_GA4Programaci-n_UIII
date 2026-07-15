internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: José Montenegro \n" +
            "Grado: IVC - Clave = 22\n" +
            "===CONVERSIONES===");
        double metros, result;
        Console.Write("Dame una medida en metros: ");
        metros = double.Parse(Console.ReadLine());

        Console.WriteLine("Menú Principal");
        Console.WriteLine("1 - Milimetros\n " + 
            "2- Centimetros\n"+
            "3- Decimetros\n" +
            "4- Hectómetros\n"+
            "5- Kilómetros\n"+
            "6- Salir \n"+
            "Seleccione una Opción []: ");
        int opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("CONVERSIÓN A MILIMETROS");
                result = metros * 1000;
                Console.WriteLine("Los metros "+metros+" en Milimetros es: "+result);
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("CONVERSIÓN A CENTIMETROS");
                result = metros * 100;
                Console.WriteLine("Los metros " + metros + " en Centímetros es: " + result);
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("CONVERSIÓN A DECIMETROS");
                result = metros * 10;
                Console.WriteLine("Los metros " + metros + " en Decímetros es: " + result);
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("CONVERSIÓN A HECTÓMETROS");
                result = metros / 100;
                Console.WriteLine("Los metros " + metros + " en Hectómetros es: " + result);
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("CONVERSIÓN A KILÓMETROS");
                result = metros / 1000;
                Console.WriteLine("Los metros " + metros + " en Kilómetros es: " + result);
                break;
            case 6:
                Console.Clear();
                Console.WriteLine("Para salir, presione una tecla");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Opción inválida...");
                break;
        }
    }
}