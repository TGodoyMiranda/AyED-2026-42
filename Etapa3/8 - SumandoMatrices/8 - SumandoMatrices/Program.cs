using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rnd = new Random();
            Console.WriteLine("Ingrese numero de filas: ");
            int Fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero de columnas: ");
            int Col = int.Parse(Console.ReadLine());
            int[,] MatrizA = new int[Fila, Col];
            int[,] MatrizB = new int[Fila, Col];
            int[,] MatrizC = new int[Fila, Col];
            Console.WriteLine();
            Console.WriteLine("Matriz A:");
            for (int i = 0; i < Fila; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    MatrizA[i, j] = Rnd.Next(1, 101);
                    Console.Write(MatrizA[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Matriz B:");
            for (int i = 0; i < Fila; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    MatrizB[i, j] = Rnd.Next(1, 101);
                    Console.Write(MatrizB[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Matriz C (Suma de A y B):");
            for (int i = 0; i < Fila; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    MatrizC[i, j] = MatrizA[i, j] + MatrizB[i, j];
                    Console.Write(MatrizC[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
