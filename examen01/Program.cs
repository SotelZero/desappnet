using System;
using System.Globalization;
using Redes.Clases;
using System.Collections.Generic;

namespace Redes
{
    class Program
    {
        static void Main(string[] args)
        {
            int vultot=0;
            CultureInfo InfoCultural = new CultureInfo("en-US");
            Red miRed = new Red("Red Patito, S.A. de C.V.","Mr Pato Macdonald","Av.Priceton 123, Orlando Florida");

            miRed.AgregarNodo(new Nodo("192.168.0.10","servidor","5","10","Linux"));
            miRed.AgregarNodo(new Nodo("192.168.0.12","Equipo activo","2","12","IOS"));
            miRed.AgregarNodo(new Nodo("192.168.0.20","Computadora","8","5","Windows"));
            miRed.AgregarNodo(new Nodo("192.168.0.15","servidor","10","22","Linux"));
            
            Vulnerabilidad vlnd1 = new Vulnerabilidad("CVE-2015-1635","microsoft","HTTP.sys permite a atacantes remotos ejecutar codigo arbitrario","remota", DateTime.Parse("04/14/2015",InfoCultural));
            Vulnerabilidad vlnd2 = new Vulnerabilidad("CVE-2017-0004","microsoft","El servidor LSASS permite causar una denegacion de servicio","local", DateTime.Parse("01/10/2001",InfoCultural));
            Vulnerabilidad vlnd3 = new Vulnerabilidad("CVE-2017-3847","cisco","Cisco Firepower Management Center XSS","remota", DateTime.Parse("02/21/2017",InfoCultural));
            Vulnerabilidad vlnd4 = new Vulnerabilidad("CVE-2009-2504","microsoft","Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1","local", DateTime.Parse("11/13/2009",InfoCultural));
            Vulnerabilidad vlnd5 = new Vulnerabilidad("CVE-2016-7271","microsoft","Elevación de privilegios Kernel Segura en Windows 10 Gold","local", DateTime.Parse("12/20/2016",InfoCultural));
            Vulnerabilidad vlnd6 = new Vulnerabilidad("CVE-2017-2996","adobe","Adobe Flash Player 24.0.0.194 corrupción de memoria explotable","remota", DateTime.Parse("02/15/2017",InfoCultural));

            miRed.Nodos[0].AgregarVlnd(vlnd1);
            miRed.Nodos[0].AgregarVlnd(vlnd2);
            miRed.Nodos[1].AgregarVlnd(vlnd3);
            miRed.Nodos[2].AgregarVlnd(vlnd4);
            miRed.Nodos[2].AgregarVlnd(vlnd5);
            miRed.Nodos[2].AgregarVlnd(vlnd6);

            for (int i = 0; i < miRed.Nodos.Count; i++)
            {
                vultot+=miRed.Nodos[i].vlnd.Count;
            }
            
            Console.WriteLine("Datos generales de la Red:\n");

            Console.WriteLine($"Empresa: {miRed.Empresa}");
            Console.WriteLine($"Propietario: {miRed.Propietario}");
            Console.WriteLine($"Domicilio: {miRed.Domicilio}");

            Console.WriteLine($"\nTotal nodos de red: {miRed.Nodos.Count}");
            Console.WriteLine($"Total vulnerabilidades: {vultot} \n");

            Console.WriteLine("Datos generales de los nodos\n");

            Console.WriteLine($"IP: {miRed.Nodos[0].Ip}, Tipo: {miRed.Nodos[0].Tipo}, Puertos: {miRed.Nodos[0].Puertos}, Saltos {miRed.Nodos[0].Saltos}, S.O. {miRed.Nodos[0].So}, TotalVul: {miRed.Nodos[0].vlnd.Count}");
            Console.WriteLine($"IP: {miRed.Nodos[1].Ip}, Tipo: {miRed.Nodos[1].Tipo}, Puertos: {miRed.Nodos[1].Puertos}, Saltos {miRed.Nodos[1].Saltos}, S.O. {miRed.Nodos[1].So}, TotalVul: {miRed.Nodos[1].vlnd.Count}");
            Console.WriteLine($"IP: {miRed.Nodos[2].Ip}, Tipo: {miRed.Nodos[2].Tipo}, Puertos: {miRed.Nodos[2].Puertos}, Saltos {miRed.Nodos[2].Saltos}, S.O. {miRed.Nodos[2].So}, TotalVul: {miRed.Nodos[2].vlnd.Count}");
            Console.WriteLine($"IP: {miRed.Nodos[3].Ip}, Tipo: {miRed.Nodos[3].Tipo}, Puertos: {miRed.Nodos[3].Puertos}, Saltos {miRed.Nodos[3].Saltos}, S.O. {miRed.Nodos[3].So}, TotalVul: {miRed.Nodos[3].vlnd.Count}");
        }
    }
}
