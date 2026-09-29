using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Sumando2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sumar(1, 2));
            Console.ReadKey();
        }
        static int Sumar(int Valor1, int Valor2)
        {
            int Valorfinal = Valor1 + Valor2;
            return Valorfinal;
        }
    }
}
