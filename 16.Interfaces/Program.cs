using System;
using Interfaces.Clases;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Caja> costal=LlenarCostal();

            Caja miCaja = new Caja("Roja",true,"calzones",10,20);
            Console.WriteLine("Ejemplo de Interfaces \n\n");

            costal.Add(miCaja);
            foreach(Caja c in costal) {
                Console.WriteLine($"Color:{c.Color}"); 
                Console.WriteLine($"Estatus:{(c.EstaAbierta?"Abierta":"Cerrada")}");
                Console.WriteLine($"Contenido:{(c.EstaAbierta?c.Contenido:"nel")}");
                Console.WriteLine($"Dimensiones:{c.Medidas()}"); 
            }
        }

        static List<Caja> LlenarCostal() {
            List<Caja> todo = new List<Caja>();
            todo.Add(new Caja("Rojo",false,"Manzanas",10,10)); 
            todo.Add(new Caja("Verde",false,"Pepinos",10,10)); 
            todo.Add(new Caja("Azul",false,"Nubes",10,10)); 
            todo.Add(new Caja("Negro",false,"Carbon",10,10)); 
            todo.Add(new Caja("Blanca",false,"Manzanas",10,10)); 
            todo.Add(new Caja("Rosa",false,"Flores",10,10)); 
            return todo;
        }
    }
}
