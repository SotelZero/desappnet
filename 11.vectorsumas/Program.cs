using System;

namespace _11.vectorsumas
{
    class Program
    {
        static void Main(string[] args)
        {
            int contCeros = 0, contPos = 0, contNeg = 0;
            double sumaPost = 0, sumaNeg = 0;

            Random rdm = new Random();
            double[] vector = new double[20];

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rdm.Next(-100, 100);

                if (vector[i] == 0)
                {
                    contCeros++;
                }
                else if (vector[i] < 0)
                {
                    contPos++;
                    sumaNeg += vector[i];
                }
                else if (vector[i] > 1)
                {
                    contNeg++;
                    sumaPost += vector[i];
                }   
            } 

            imprimir(vector);
            Console.WriteLine($"Num iguales a 0: {contCeros}");
            Console.WriteLine($"Num menores a 0: {contNeg}");
            Console.WriteLine($"Num mayores a 0: {contPos}");
            Console.WriteLine($"suma de numeros mayores a 0: {sumaPost}");
            Console.WriteLine($"suma de numeros menores a 0: {sumaNeg}");
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
