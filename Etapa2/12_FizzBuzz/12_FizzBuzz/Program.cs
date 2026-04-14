using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num != 101)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (num % 3 == 0 && num % 3 == 5)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(num);
                }
                    num += 1;
            }
            Console.ReadKey();
        }
    }
}
