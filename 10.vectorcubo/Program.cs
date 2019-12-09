using System;

namespace _10.vectorcubo
{
    class Program
    {
        static void Main(string[] args)
        {
           double[] vectorA, vectorB;

            vectorA = new double[20];
            vectorB = new double[20];

            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                vectorA[i] = rnd.Next(1, 100);
                vectorB[i] = Math.Pow(vectorA[i],2);
            }

            Console.WriteLine("El vector A es:");
            imprimir(vectorA);
            Console.WriteLine("El vector B es:");
            imprimir(vectorB);

        }

        static void imprimir(double[] vector)
        {
            for (int i = 0; i < vector.Length ; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
