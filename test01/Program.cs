using System;
using test01.Clases;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo del uso de interfaces \n");
            IPluma miCello = new Cello("Azul");
            IPluma miParker = new Parker("Negro");

            miCello.Abrir();
            miCello.Color = "Azul";
            miCello.Escribir($"Escribiendo este mensaje con la pluma marca Cello en color {miCello.Color} \n");
            miCello.Cerrar();

            miParker.Abrir();
            miParker.Color="Negro";
            miParker.Escribir($"Parker escribe mejor los mensaje por ahora en color {miParker.Color} \n");
            miParker.Cerrar();

            
        }
    }
}
