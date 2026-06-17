using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___MiPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero de filas: ");
            int Fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero de columnas: ");
            int Col = int.Parse(Console.ReadLine());
            int[,] MPM = new int[Fila, Col];
            Console.WriteLine("Matriz generada:");
            for(int i = 0; i < Fila ; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    MPM[i, j] = 0;
                    Console.Write(MPM[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
