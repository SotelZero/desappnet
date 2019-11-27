using System;

namespace _06.pizza
{
    class Program
    {
        static int Main(string[] args)
        {
            string tamano="", ingredientes="", cubierta="", para="";
            string[] ing;
            char tam, cub, par;

            if(args.Length<4) {
                Console.Clear();
                Console.WriteLine("Debes especificar como quieres tu pizza \n");
                Console.WriteLine("<Tamano> <ing1+ing2+...> <Cubierta> <Para>");
                Menu();
                return 1;
            }

            // Tamano
            tam = char.Parse(args[0]);
            if(tam=='P') tamano = "Pequeno";
            else if(tam=='M') tamano="Mediana";
            else tamano = "Grande";

            // Ingredientes
            ing = args[1].Split("+");
            
            foreach(string i in ing) {
                if(i=="E") ingredientes+="Extra queso ";
                else if(i=="C") ingredientes+="Champinones ";
                else if(i=="P") ingredientes+="Pina ";
            }

            // Cubierta
            cub = char.Parse(args[2]);
            if(cub=='D') cubierta = "Delgada";
            else cubierta = "Gruesa";

            // Para
            par = char.Parse(args[3]);
            if(par=='C') para = "Comer Aqui";
            else para = "Para Llevar";

            // Imprima la orden
            Console.WriteLine("Tu pizza quedo de la siguiente forma \n");
            Console.WriteLine($"Tamano {tamano}  \n");
            Console.WriteLine($"Ingredientes {ingredientes}  \n");
            Console.WriteLine($"Cubierta {cubierta}  \n");
            Console.WriteLine($"Para {para}  \n");






            return 0;
        }

        static void Menu() {
            Console.WriteLine("Menu \n");
            Console.WriteLine("Tamano: (P)equena, (M)ediana, (G)rande\n");
            Console.WriteLine("Ingredientes: (E)xtra Queso, (C)hampiñones, (P)ina \n");
            Console.WriteLine("Cubierta: (D)elgada o (G)ruesa\n");
            Console.WriteLine("Para: (C)omer aquí o Para (L)levar.\n");
        }



    }
}
