using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_MiResta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte Un numero: ");
            int Numero_1 = int.Parse(Console.ReadLine());
            Console.Write("Inserte un segundo numero: ");
            int Numero_2 = int.Parse(Console.ReadLine());
            int Resultado = Numero_1 - Numero_2;
            Console.WriteLine("El resultado de " + Numero_1 + " menos " + Numero_2 + " es " + Resultado);
            Console.ReadKey();
        }
    }
}
