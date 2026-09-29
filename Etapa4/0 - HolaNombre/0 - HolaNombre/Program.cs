using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0___HolaNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            HolaNombre("Juan");
            Console.ReadKey();
        }
        static void HolaNombre(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }
    }
}
