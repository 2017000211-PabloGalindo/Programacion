internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un numero de la semana (1-7):");
        int dia = Convert.ToInt32(Console.ReadLine());

        if ((dia == 6) || (dia == 7))
            Console.WriteLine("FIN DE SEMANA");
        else if ((dia >= 1) && (dia <= 5))
            Console.WriteLine("ENTRE SEMANA");
        else
            Console.WriteLine("NUMERO INVALIDO");

    }
}