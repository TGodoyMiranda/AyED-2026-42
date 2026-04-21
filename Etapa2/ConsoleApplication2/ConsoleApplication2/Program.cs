using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayoriadeedad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cual es tu edad?");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("No eres mayor de edad");
            }
            Console.ReadKey();
        }
    }
}
