using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3AnalisisGuia6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Identificador de triángulos";


            Double n1, n2, n3, equi, iso, esc;
            equi = 0;
            iso = 0;
            esc = 0;
            int i;
           
            for (i = 1; i <= 5; i++)

            {
            Console.WriteLine("");
            Console.WriteLine("Ingrese el valor del primer lado del triángulo:");
            n1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo lado del triángulo:");
            n2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del tercer lado del triángulo:");
            n3 = Double.Parse(Console.ReadLine());

            if (n1 == n2 && n1 == n3)
            {
            Console.WriteLine("Es un triángulo equilatero.");
            equi ++;
            }
            else if (n1 == n2 || n1 == n3 || n2 == n3 || n2 == n3)
            {
            Console.WriteLine("Es un triángulo isoceles.");
            iso++;
            }
            else
            {
            Console.WriteLine("Es un triángulo escaleno.");
            esc++;
            }
            }
            
            Console.WriteLine("> Cantidad de triángulos equilateros: " + equi + ".");
            Console.WriteLine("> Cantidad de triángulos isoceles: " + iso + ".");
            Console.WriteLine("> Cantidad de triángulos escalenos: " + esc + ".");

        if (equi < iso && equi < iso)
        {
        Console.WriteLine("> Son menos los tríangulos equilateros encontrados.");
        }
        else 
        {
        if (iso < esc)
        {
        Console.WriteLine("> Son menos los tríangulos isoceles encontrados.");
        }
        else
        {
        Console.WriteLine("> Son menos los tríangulos escalenos encontrados.");
        }

        Console.ReadKey();
        }
    }
}
}

