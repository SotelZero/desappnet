using System;

namespace _13.vectoresmultiplica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vectorA, vectorB, vectorC;

            vectorA = new int[20];
            vectorB = new int[20];
            vectorC = new int[20];

            leerDatos(vectorA,"A");
            leerDatos(vectorB,"B");

            multiplicar(vectorA, vectorB, vectorC);

            mostrarDatos(vectorA, "A");
            mostrarDatos(vectorB, "B");
            mostrarDatos(vectorC, "C");
        }

        static void multiplicar(int[] vectorA, int[] vectorB, int[] vectorC){

            for (int i = 0; i < vectorA.Length; i++)
            {
                vectorC[i] = vectorA[i] * vectorB[vectorB.Length-1 -i ];
            }
        }

        static void leerDatos(int[] vector, string a){
            Console.WriteLine($"Ingrese los datos delo vector {a}");

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese el elemento {i+1}");
                vector[i] = int.Parse(Console.ReadLine());
            }
        }

        static void mostrarDatos(int[] vector, string a){
             Console.WriteLine($"Datos del vector {a}");

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"{vector[i]} ");
            }
            Console.WriteLine();
        }
    }
}
