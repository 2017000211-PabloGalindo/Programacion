using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===BUZON DE VOZ");
        Console.WriteLine("1 - Ventas");
        Console.WriteLine("2 - Recepcion");
        Console.WriteLine("3 - Direccion");
        Console.WriteLine("4 - Compras");
        Console.WriteLine("Digite una opcion: ");
        string voz = Console.ReadLine();

        if (voz == "1")
        {
            Console.WriteLine("BIENVENIDO AL DEPARTAMENTO DE VENTAS");
            Console.WriteLine("Nombre Responsable: PABLO GALINDO");
            Console.WriteLine("Correo: p.galindo.5bdb@gmail.com");
        }
        else if (voz == "2")
        {
            Console.WriteLine("BIENVENIDO AL DEPARTAMENTO DE RECEPCION");
            Console.WriteLine("Nombre Responsable: ALEJANDRA ARIAS");
            Console.WriteLine("Correo: alejandraarias@resetsa.com");
        }
        else if (voz == "3")
        {
            Console.WriteLine("BIENVENIDO AL DEPARTAMENTO DE DIRECCION");
            Console.WriteLine("Nombre Responsable: RODRIGO GALINDO");
            Console.WriteLine("Correo: rodrigoogalindo@gmail.com");
        }
        else if (voz == "4")
        {
            Console.WriteLine("BIENVENIDO AL DEPARTAMENTO DE COMPRAS");
            Console.WriteLine("Nombre Responsable: JAIRO GALINDO");
            Console.WriteLine("Correo: jairoagalindo@gmail.com");
        }
        else
        {
            Console.WriteLine("ERROR");
        }
    }
}