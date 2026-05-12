using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0___CargandoEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Edades = new int[5];
            for (int i = 0; i < Edades.Length; i++)
            {
                Console.Write("Ingrese la edad numero " + i + ": ");
                Edades[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Las edades ingresadas en el vector fueron: ");
            foreach (int n in Edades)
            {
                Console.Write(n + " ");
            }
            Console.ReadKey();
        }
    }
}
