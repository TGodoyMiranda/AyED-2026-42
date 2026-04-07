using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ParOImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int Chequeo = int.Parse(Console.ReadLine());
            if (Chequeo % 2 == 0)
            {
                Console.WriteLine("Su numero es par");
            }
            else
            {
                Console.WriteLine("Su Numero es impar");
            }
            Console.ReadKey();
        }
    }
}
