using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            int num = 1;
            while (num != numero + 1)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                num += 1;
            }
            Console.ReadKey();
        }
    }
}
