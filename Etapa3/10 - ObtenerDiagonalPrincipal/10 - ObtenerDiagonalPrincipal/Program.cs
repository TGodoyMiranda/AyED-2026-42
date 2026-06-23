using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___ObtenerDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rnd = new Random();
            int n = Rnd.Next(1, 10);
            int[,] Matriz = new int[n, n];
            int[] Diagonal = new int[n];

            Console.WriteLine("Matriz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matriz[i, j] = Rnd.Next(1, 100);
                    Console.Write(Matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                Diagonal[i] = Matriz[i, i];
            }
            Console.WriteLine();
            Console.WriteLine("Los valores diagonales de la matriz son:");
            Console.WriteLine(string.Join(" ", Diagonal));
            Console.ReadKey();
        }
    }
}
