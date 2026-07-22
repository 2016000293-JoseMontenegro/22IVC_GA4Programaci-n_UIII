internal class Program
{
    private static void Main(string[] args)
    {
        string signo = "";
        Console.WriteLine("Nombre: José Montenegro \n" +
            "Grado: IVC - Clave = 22\n" +
            "===ZODIACAL Y HORÓSCOPO===");
        Console.Write("Ingrese su mes de nacimiento (1-12): ");
        int mes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su dia de nacimiento: ");
        int dia = Convert.ToInt32(Console.ReadLine());

        if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
            signo = "Aries";
        else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
            signo = "Tauro";
        else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
            signo = "Geminis";
        else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
            signo = "Cancer";
        else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
            signo = "Leo";
        else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
            signo = "Virgo";
        else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
            signo = "Libra";
        else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
            signo = "Escorpio";
        else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
            signo = "Sagitario";
        else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
            signo = "Capricornio";
        else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
            signo = "Acuario";
        else if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20))
            signo = "Piscis";
        else
        {
            Console.WriteLine("Fecha invalida.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Tu signo zodiacal es: " + signo);
        Console.WriteLine("Horoscopo: Todos tus deberes los podrás realizar en la mitad de tiempo de lo normal.");

        Console.WriteLine("\nPresione una tecla para cerrar...");
        Console.ReadKey();
    }
}