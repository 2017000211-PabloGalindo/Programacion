internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un numero: ");
        float num = Convert.ToInt32(Console.ReadLine());

        if (num < 0)
            Console.WriteLine("El numero es negativo: ");
        else
            Console.WriteLine("El numero es positivo: ");
    }
}