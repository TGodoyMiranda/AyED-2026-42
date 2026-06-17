using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___MatrizRotada90
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rnd = new Random();
            Console.WriteLine("Ingrese numero de filas y columnas: ");
            int FC = int.Parse(Console.ReadLine());
            int[,] MatrizA = new int[FC, FC];
            int[] vectorRotado = new int[FC * FC];
            int[,] matrizRotada = new int[FC, FC];
            Console.WriteLine();
            Console.WriteLine("Matriz A:");

            for (int i = 0; i < FC; i++)
            {
                for (int j = 0; j < FC; j++)
                {
                    MatrizA[i, j] = Rnd.Next(1, 101);
                    Console.Write(MatrizA[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < FC; i++)
            {
                for (int j = 0; j < FC; j++)
                {
                    int indiceVector = (FC - 1 - j) * FC + i;
                    vectorRotado[indiceVector] = MatrizA[i, j];
                }
            }
            int index = 0;

            for (int i = 0; i < FC; i++)
            {
                for (int j = 0; j < FC; j++)
                {
                    matrizRotada[i, j] = vectorRotado[index];
                    index++;
                }
            }
            Console.WriteLine("Matriz Rotada 90 grados:");
            for (int i = 0; i < FC; i++)
            {
                for (int j = 0; j < FC; j++)
                {
                    Console.Write(matrizRotada[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}