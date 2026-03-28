internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingresa el lado 1: ");
        int lado1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa el lado 2: ");
        int lado2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa el lado 3: ");
        int lado3 = Convert.ToInt32(Console.ReadLine());

        if ((lado1 == lado2) && (lado2 == lado3))
            Console.WriteLine("El triangulo es: Equilatero");
        else if ((lado1 == lado2) || (lado1 == lado3) || (lado2 == lado3))
            Console.WriteLine("El triangulo es: Isosceles");
        else
            Console.WriteLine("El triangulo es: Escaleno");
    }
}