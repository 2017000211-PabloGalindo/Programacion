internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==MENU PRINCIPAL===");
        Console.WriteLine("1- Recepcion");
        Console.WriteLine("2- Contabilidad");
        Console.WriteLine("3- Mantenimiento");
        Console.WriteLine("4- Salir");
        Console.WriteLine("Digite una opcion: ");
        int opc= Convert.ToInt32(Console.ReadLine());

        if (opc == 1)
            Console.WriteLine("Bienvenido al Departamento de Recepcion");
        if (opc == 2)
            Console.WriteLine("Bienvenido al Departamento de Contabilidad");
        if (opc == 3)
            Console.WriteLine("Bienvenido al Departamento de Contabilidad");
        if (opc != 1 && opc != 2 && opc != 3)
            Console.WriteLine("Salir del Sistema");
    }
}