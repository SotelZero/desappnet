using System;

namespace _07.tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, op2;

            menu();
            op = Int32.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Ingresa el numero de la tabla de multiplicar");
                op2 = Int32.Parse(Console.ReadLine());
                imprimirTabla(op2);
            }
            else if (op == 2)
            {
                Console.WriteLine("Ingresa hasta que tabla de multiplicar quieres imprimir");
                op2 = Int32.Parse(Console.ReadLine());
                imprimirTablas(op2);
            }else{
                Console.WriteLine("Error de opcion!");
            }
        }

        static void imprimirTablas(int numero){

            Console.WriteLine("Tablas: ");
            for (int i = 1; i <= numero; i++)
            {
                
                imprimirTabla(i);
            }
        }

        static void imprimirTabla(int numero){

            Console.WriteLine("Tabla del: " + numero);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero*i}");
            }
            Console.WriteLine("\n");
        }

         static void menu()
        {
            Console.WriteLine("Ingresa la opcion a realizar");
            Console.WriteLine("[1] imprimir tabla de multiplicar en especifico");
            Console.WriteLine("[2] imprimr varias tablas de multiplicar");
        }
    }
}
