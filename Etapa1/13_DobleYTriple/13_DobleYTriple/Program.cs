using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DobleYTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte un numero entero: ");
            int Numero_entero = int.Parse(Console.ReadLine());
            int Doble = Numero_entero * 2;
            int Triple = Numero_entero * 3;
            Console.WriteLine("Tu numero 2 veces es: " + Doble);
            Console.Write("Tu numero 3 veces es: " + Triple);
            Console.ReadKey();
        }
    }
}
