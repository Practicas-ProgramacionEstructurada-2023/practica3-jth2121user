using System;
using System.Xml.Schema;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

        // DECLARACION DE VARIABLES DE TIPO TEXTO

        string? marca_zapato;
        string? color_zapato;

        // DECLARACION DE VARIABLES DE TIPO ENTEROS

        int cantitad;

         // DECLARACION DE VARIABLES DE TIPO DOUBLE

        double precio_zapato;

        // CAPTURAR DATOS
        
        Console.WriteLine("\n <<<<<<<<<< capturando variables >>>>>>>>>>");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Ingrese la marca de zapato a comprar: ");
        marca_zapato = Convert.ToString(Console.ReadLine());

        Console.WriteLine("\nIngrese el color del par de zapatos: ");
        color_zapato = Convert.ToString(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nIngrese la cantidad de pares de zapatos a comprar: ");
        cantitad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nIngrese el precio del par de zapatos a comprar: ");
        precio_zapato = Convert.ToDouble(Console.ReadLine());
        Console.ResetColor();
        Console.WriteLine("<<<<<<<<<< fin de capturacion de variables >>>>>>>>>>\n");
        
        // CAPTURANDO TOTAL A PAGAR

        double total = cantitad*precio_zapato;

        // IMPRIMIR RESULTADOS

        Console.WriteLine("\n<<<<<<<<<< Imprimiendo resultados >>>>>>>>>>");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("La marca de zapatos a comprar es: " + marca_zapato);
        Console.WriteLine("\nEl color de los zapatos a comprar es: " + color_zapato);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nLa cantidad de pares de zapatos a comprar es: " + cantitad);
        Console.WriteLine("\nEl precio por par de zapatos a comprar es:  $"+ precio_zapato);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nEl total a pagar es: $"+ total);
        Console.ResetColor();
        Console.WriteLine("<<<<<<<<<< Fin de imprimir resultados >>>>>>>>>>\n");

        }
    }
}

  