using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la cantidad de filas: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la cantidad de columnas: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int[,] b = new int[a, d]; float promedio2; float promedio4; float promediototal2; float promediototal = 0;
            int[,] c = new int[1, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int j = 0; j < d; j++)
            {
                float promedio3 = 0;
                float promedio = 0;
               
                for (int i = 0; i < a; i++)
                {
                    promedio += b[i,j];
                    promedio3 += b[j, i];
                }
                promedio2 = promedio / a;
                promedio4 = promedio3 / d;
                Console.WriteLine("PromedioC{0}: {1}", j + 1, promedio2);
                Console.WriteLine("PromedioF{0}: {1}", j + 1, promedio4);
                promedio = 0;
            }
            for (int i = 0; i<a; i++)
            {
                for (int j = 0; j<d; j++)
                {
                    promediototal += b[i, j];
                }
            }
            promediototal2 = promediototal / (a * d);
            Console.WriteLine("Promedio total: {0}", promediototal2);
            Console.ReadKey();
        }
    }
}