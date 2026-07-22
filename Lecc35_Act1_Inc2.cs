internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: José Montenegro \n" +
           "Grado: IVC - Clave = 22\n" +
           "===BILLETES===");
        Console.Write("Ingrese el precio del producto: Q");
        int precio = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la cantidad con que pago: Q");
        int pago = Convert.ToInt32(Console.ReadLine());

        if (pago < precio)
        {
            Console.WriteLine("El dinero entregado no es suficiente.");
            Console.ReadKey();
            return;
        }

        int cambio = pago - precio;
        int restante = cambio;

        int b200 = restante / 200;
        restante = restante % 200;

        int b100 = restante / 100;
        restante = restante % 100;

        int b50 = restante / 50;
        restante = restante % 50;

        int b20 = restante / 20;
        restante = restante % 20;

        int m10 = restante / 10;
        restante = restante % 10;

        int m5 = restante / 5;
        restante = restante % 5;

        int m1 = restante;

        Console.WriteLine();
        Console.WriteLine("Cambio total: Q" + cambio);
        Console.WriteLine("Billetes de Q200: " + b200);
        Console.WriteLine("Billetes de Q100: " + b100);
        Console.WriteLine("Billetes de Q50: " + b50);
        Console.WriteLine("Billetes de Q20: " + b20);
        Console.WriteLine("Monedas de Q10: " + m10);
        Console.WriteLine("Monedas de Q5: " + m5);
        Console.WriteLine("Monedas de Q1: " + m1);

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para cerrar...");
        Console.ReadKey();
    }
}