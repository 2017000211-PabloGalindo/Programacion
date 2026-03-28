internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite una opcion: ");
        int dia = Convert.ToInt32(Console.ReadLine());

        if (dia == 1)
            Console.WriteLine("HOY ES LUNES");
        if (dia == 2)
            Console.WriteLine("HOY ES MARTES");
        if (dia == 3) 
            Console.WriteLine("HOY ES MIERCOLES");
        if (dia == 4)
            Console.WriteLine("HOY ES JUEVES");
        if (dia == 5)
            Console.WriteLine("HOY ES VIERNES");
        if (dia == 6)
            Console.WriteLine("HOY ES SABADO");
        if (dia == 7)
            Console.WriteLine("HOY ES DOMINGO");
        if (dia != 1 && dia != 2 && dia != 3 && dia != 4 && dia != 5 && dia != 6 && dia != 7)
            Console.WriteLine("NUMERO NO VALIDO");
    }
}