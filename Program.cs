internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===MENSAJE DE VOZ===");
        //Variable
        int opc;
        //Crear el menu
        Console.WriteLine("MENU PRINCIPAL\n");
        Console.WriteLine("1- Recepcio\n");
        Console.WriteLine("2- Vigilancia\n");
        Console.WriteLine("3- Mantenimiento\n");
        Console.WriteLine("4- Salir\n");
        Console.Write("Digite una Opcion []: ");
        opc = Convert.ToInt32(Console.ReadLine());

        //Condiciones
        if (opc == 1)
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al Departamento Recepcion");
        }
        if (opc == 2)
            Console.WriteLine("Bienvenido al Departamento Vigilancia");
        if (opc == 3)
            Console.WriteLine("Bienvenido al Departamento Mantenimiento");
        if (opc != 1 && opc != 2 && opc != 3)
            Console.WriteLine("Saliendo del Sistema");

        //Limpiar pantalla
        Console.Clear();
    }
}