using System;

namespace _03.areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float area, b, a;

            Console.WriteLine("Programa que calcula el area de un triangulo");

            if(args.Length<2) {
                Console.WriteLine("Forma de uso \n");
                Console.WriteLine("<base> <altura>");
                Environment.Exit(0);
            }

            b = float.Parse(args[0]);
            a = float.Parse(args[1]);

            area =  (b*a) /2 ;

            Console.WriteLine($"El triangulo de base {b} y altura {a} tiene una area de {area}");           

        }
    }
}
