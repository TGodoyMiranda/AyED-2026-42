using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0___MayorDeEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad aqui: ");
            int Edad = int.Parse(Console.ReadLine());
            if (Edad >= 18) {
                Console.Write("Eres mayor de edad.");
            }
            else
            {
                Console.Write("Eres menor de edad.");
            }
            Console.ReadKey();
        }
    }
}
