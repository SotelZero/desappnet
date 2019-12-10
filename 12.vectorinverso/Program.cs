using System;

namespace _12.vectorinverso
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vectorA, vectorB;

            vectorA = new double[15];
            vectorB = new double[15];

            Random rdm = new Random();

            for (int i = 0; i < vectorA.Length; i++)
            {
                vectorA[i] = rdm.Next(1, 100);
                vectorB[14-i] = vectorA[i];
            }

            Console.WriteLine("Vector original:");
            imprimir(vectorA);
            Console.WriteLine("Vector inverso:");
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
