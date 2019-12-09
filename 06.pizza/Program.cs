using System;

namespace _06.pizza
{
    class Program
    {
        static int Main(string[] args)
        {   
            string t = "", c = "", p = "", ing = "";
            string[] ings;

            if(args.Length < 4){
                menu();
                return 1;
            }

            t = args[0];

            if(t=="P"){
                t = "Pequenio ";
            }
            else if(t=="M"){
                t = "Mediana ";
            }else{
                t = "Grande ";
            }

            c = args[2];

            if(c=="D"){
                c = "Delgada ";
            }else{
               c = "Gruesa "; 
            }

            p = args[3];

            if(c=="C"){
                p = "Comer aqui ";
            }else{
               p = "Para llevar "; 
            }
            

            ings = args[1].Split(",");

            foreach(string e in ings){
                if(e == "E"){
                    ing +="Extra queso, ";
                }
                if(e == "C"){
                    ing +="Champinion, ";
                }
                if(e == "PI"){
                    ing +="Pinia, ";
                }
            }
            Console.WriteLine(t + c + p + ing);
            return 0;
        }

        static void menu(){
            Console.Clear();
            Console.WriteLine("Debes especificar ccomo quieres tu pizza");
            Console.WriteLine("<Tamanio> <Ingredientes,..., s> <Cubierta> <Para>");
            Console.WriteLine("Menu \n");
            Console.WriteLine("Tamanio: (P)equena, (M)ediana, (G)rande  ");
            Console.WriteLine("Ingredienetes: (E)xtra queso, (C)ampinion, (PI)inia");
            Console.WriteLine("Cubierta: (D)elgada, (G)ruesa ");
            Console.WriteLine("Para: (C)omer aqui, (L)levar ");
        }
    }
}
