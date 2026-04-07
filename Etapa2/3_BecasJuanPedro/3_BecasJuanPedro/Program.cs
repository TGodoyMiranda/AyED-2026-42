using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BecasJuanPedro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int Cond1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su ingreso mensual: ");
            int Cond2 = int.Parse(Console.ReadLine());
            if (Cond1 > 19 && Cond2 <= 100000 || Cond1 < 19 && Cond2 == 0 || Cond1 == 19 && Cond2 <= 50000) {
                Console.WriteLine("Eres elegible para la beca.");
            }
            else
            {
                Console.WriteLine("No eres elegible para la beca.");
            }
            Console.ReadKey();
        }
    }
}
