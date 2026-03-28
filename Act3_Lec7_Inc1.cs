internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el numero del dia (1-31): ");
        int dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el numero del mes (1-12): ");
        int mes = Convert.ToInt32(Console.ReadLine());

        if ((mes == 3 && dia >= 21) || (mes == 4) || (mes == 5) || (mes == 6 && dia < 21))
                Console.WriteLine("La Estacion es: Primavera");
        else if ((mes == 6 && dia >= 21) || (mes == 7) || (mes == 8) || (mes == 9 && dia < 21))
            Console.WriteLine("La Estacion es: Verano");
        else if ((mes == 9 && dia >= 21) || (mes == 10) || (mes == 11) || (mes == 12 && dia < 21))
            Console.WriteLine("La Estacion es: Otoño");
        else
            Console.WriteLine("La Estacion es: Invierno");
    }
}