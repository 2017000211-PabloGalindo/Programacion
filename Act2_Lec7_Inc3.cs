internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite un numero: ");
        int mes = Convert.ToInt32(Console.ReadLine());

        if (mes == 1)
            Console.WriteLine("Mes: ENERO");
        if (mes == 2)
            Console.WriteLine("Mes: FEBRERO");
        if (mes == 3)
            Console.WriteLine("Mes: MARZO");
        if (mes == 4)
            Console.WriteLine("Mes: ABRIL");
        if (mes == 5)
            Console.WriteLine("Mes: MAYO");
        if (mes == 6)
            Console.WriteLine("Mes: JUNIO");
        if (mes == 7)
            Console.WriteLine("Mes: JULIO");
        if (mes == 8)
            Console.WriteLine("Mes: AGOSTO");
        if (mes == 9)
            Console.WriteLine("Mes: SEPTIEMBRE");
        if (mes == 10)
            Console.WriteLine("Mes: OCTUBRE");
        if (mes == 11)
            Console.WriteLine("Mes: NOVIEMBRE");
        if (mes == 12)
            Console.WriteLine("Mes: DICIEMBRE");
        if (mes != 1 && mes != 2 && mes != 3 && mes != 4 && mes != 5 && mes != 6 && mes != 7 && mes != 8 && mes != 9 && mes != 10 && mes != 11 && mes != 12)
            Console.WriteLine("MES NO VALIDO");
    }
}