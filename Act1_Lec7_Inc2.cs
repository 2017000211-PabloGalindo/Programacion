using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite una edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
            Console.WriteLine("ES MAYOR DE EDAD");
        else
            Console.WriteLine("ES MENOR DE EDAD");
    }
}