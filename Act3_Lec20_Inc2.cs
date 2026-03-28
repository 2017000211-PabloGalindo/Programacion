internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingresa una nota: ");
        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota >= 70)
            Console.WriteLine("ALUMNO APROBADO");
        else
            Console.WriteLine("ALUMNO REPROBADO");
    }
}