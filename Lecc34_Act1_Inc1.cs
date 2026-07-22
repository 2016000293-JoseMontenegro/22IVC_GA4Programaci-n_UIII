internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: José Montenegro \n" +
           "Grado: IVC - Clave = 22\n" +
           "===DECIMAL A BINARIO===");
        Console.WriteLine("1. Decimal a binario");
        Console.WriteLine("2. Binario a decimal");
        Console.Write("Seleccione una opcion: ");
        int opc = Convert.ToInt32(Console.ReadLine());

        if (opc == 1)
        {
            Console.Write("Ingrese un numero decimal: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("Numero binario: 0");
            }
            else
            {
                int copia = num;
                string binario = "";

                while (copia > 0)
                {
                    int residuo = copia % 2;
                    binario = residuo.ToString() + binario;
                    copia = copia / 2;
                }

                Console.WriteLine("Numero binario: " + binario);
            }
        }
        else if (opc == 2)
        {
            Console.Write("Ingrese un numero binario: ");
            string binario = Console.ReadLine();

            int result = 0;
            bool valido = true;

            for (int i = 0; i < binario.Length; i++)
            {
                char digito = binario[i];

                if (digito != '0' && digito != '1')
                {
                    valido = false;
                    break;
                }

                result = result * 2 +
                            Convert.ToInt32(digito.ToString());
            }

            if (valido)
                Console.WriteLine("Numero decimal: " + result);
            else
                Console.WriteLine("Numero binario invalido.");
        }
        else
        {
            Console.WriteLine("Opcion invalida.");
        }

        Console.WriteLine();
        Console.WriteLine("Presione una tecla para cerrar...");
        Console.ReadKey();
    }
}