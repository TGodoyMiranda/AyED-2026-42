using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___CalificacionesEstudiantiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = { "Ana", "Pedro", "Martina", "Juan", "Estrella", "Santillan" };
            Random Rnd = new Random();
            Console.WriteLine("Ingrese numero de filas: ");
            int Fila = int.Parse(Console.ReadLine());
            string[,] MPM = new string[Fila, 3];
            Console.WriteLine("Matriz generada:");
            for (int i = 0; i < Fila; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        MPM[i, j] = Nombres[Rnd.Next(1, 6)];
                        Console.Write(MPM[i, j] + " ");
                    }
                    else if (j == 1)
                    {
                        MPM[i, j] = Rnd.Next(5, 19).ToString();
                        Console.Write(MPM[i, j] + " años ");
                    }
                    else
                    {
                        MPM[i, j] = Rnd.Next(1, 100).ToString();
                        Console.Write("Nota: " + MPM[i,j]);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
