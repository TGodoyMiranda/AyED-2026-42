using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            int num = 1;
            while(num <= edad)
            {
                Console.WriteLine("Cumpliste " + num);
                num += 1;
            }
            Console.ReadKey();
        }
    }
}
