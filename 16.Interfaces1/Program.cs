using System;
using Interfaces.Clases;
using System.Collections.Generic;


namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo del uso de interfaces \n");
         
            List<Caja> regalos = AgregarDatosMuesrta();

            Console.Clear();
            Console.WriteLine("Listado de Regalos de Navidad\n");
            foreach (Caja c in regalos) {
                Console.Write($"{c.Color} - ");
                Console.Write($"{(c.estaAbierta?"Abierta":"Cerrada")} - ");
                Console.Write($"{(c.estaAbierta?c.Contenido:"")}");
                Console.Write($" - {c.Largo} - {c.Ancho}\n");
            }
            Console.WriteLine($"Total de regalos {regalos.Count}");
            
        }

       
        static List<Caja> AgregarDatosMuesrta()
        {
            List<Caja> datos = new List<Caja>();
            datos.Add(new Caja {Color="Rojo",Contenido="Calcetines",estaAbierta=true,Largo=20,Ancho=10});
            datos.Add(new Caja {Color="Azul",Contenido="Llaveros",estaAbierta=false,Largo=20,Ancho=40});
            datos.Add(new Caja {Color="Amarillo",Contenido="Llaves",estaAbierta=true,Largo=30,Ancho=25});
            datos.Add(new Caja {Color="Verde",Contenido="Verduras",estaAbierta=true,Largo=20,Ancho=10});
            datos.Add(new Caja {Color="Rosa",Contenido="Corazones",estaAbierta=false,Largo=20,Ancho=15});
            datos.Add(new Caja {Color="Purpura",Contenido="Inciencos",estaAbierta=true,Largo=30,Ancho=10});
            datos.Add(new Caja {Color="Violeta",Contenido="Flores",estaAbierta=true,Largo=20,Ancho=10});
            datos.Add(new Caja {Color="Marron",Contenido="Zapatos",estaAbierta=false,Largo=30,Ancho=20});
            datos.Add(new Caja {Color="Blanco",Contenido="Toallas",estaAbierta=true,Largo=20,Ancho=18});
            datos.Add(new Caja {Color="Negro",Contenido="Grasa",estaAbierta=true,Largo=20,Ancho=12});
            return datos;
              
        }


    }
}
