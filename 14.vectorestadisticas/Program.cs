using System;

namespace _14.vectorestadisticas
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A;
            int n;

            Console.WriteLine("Cuantos elementos?"); n=int.Parse(Console.ReadLine());
            A= new double[n];

            Console.WriteLine("Dame los elementos del arreglo \n");
            leer(A);

            Console.WriteLine("Estadisticas \n");
            Console.WriteLine($"Mayor: {mayor(A)}\n");
            Console.WriteLine($"Menor: {menor(A)}\n");
            Console.WriteLine($"Promedio: {media(A)}\n");
            Console.WriteLine($"Varianza: {varianza(A, media(A))}\n");
            Console.WriteLine($"Desv estandar: {Math.Sqrt(varianza(A, media(A)))}\n");
        }
         static double varianza(double[] v,double media)
        {
            double s=0;
            for(int i=0; i<v.Length; i++)
                s+=Math.Pow(v[i]-media,2);
            return s/v.Length-1;
        }
           static double media(double[] v)
        {
            double s=0;
            for(int i=0; i<v.Length; i++)
                s+=v[i];
            return s/v.Length;
        }
         static double menor(double[] v)
        {
            double m=v[0];
            for(int i=0; i<v.Length; i++)
                if (v[i]<m) m=v[i];
            return m;
        }


        static double mayor(double[] v)
        {
            double m=v[0];
            for(int i=0; i<v.Length; i++)
                if (v[i]>m) m=v[i];
            return m;
        }

        static void leer(double[] v)
        {
            for(int i=0; i<v.Length; i++)
            {
                Console.WriteLine($"Elemento[{i+1}] =");
                v[i]=double.Parse(Console.ReadLine());
            }
        }
    }
}
