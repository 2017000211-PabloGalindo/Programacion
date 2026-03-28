internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingresa tu contraseña: ");
        string num;
        num = Console.ReadLine();

        if (num == "Password123")
            Console.WriteLine("!!!BIENVENIDO¡¡¡");
        else
            Console.WriteLine("EL INGRESO ESTA PROHIBIDO");
    }
}