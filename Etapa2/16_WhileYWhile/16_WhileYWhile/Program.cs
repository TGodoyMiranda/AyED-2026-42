using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WhileYWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("------- Numeros impares entre 0 y 100");
            while (n <= 100)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);
                }
                n += 1;
            }
            n = 0;
            Console.WriteLine("------- Numeros pares entre 0 y 100");
            while (n <= 100)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
                n += 1;
            }
            n = 0;
            Console.WriteLine("------- Numeros de 0 a 100");
            while (n <= 100)
            {

                Console.WriteLine(n);
                n += 1;
                    }
            Console.WriteLine("------- Numeros de 100 a 0");
            while (n >= 0)
            {

                Console.WriteLine(n);
                n -= 1;
                    }
            n = 0;
            Console.WriteLine("------- Multiplos de 3 entre 0 y 100");
            while (n <= 100)
            {
                if (n % 3 == 0)
                {
                    Console.WriteLine(n);
                }
                n += 1;
            }
            n = 0;
            Console.WriteLine("------- Multiplos de 3 y 5 entre 0 y 100");
            while (n <= 100)
            {
                if (n % 3 == 0 && n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
                n += 1;
            }
            Console.ReadKey();
        }
    }
}
