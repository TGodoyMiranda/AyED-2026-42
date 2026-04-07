using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string Contraseña = "banana";
            Console.Write("Ingrese la Contraseña: ");
            string Contras1 = Console.ReadLine();
            if (Contras1.ToLower() == Contraseña) {
                Console.WriteLine("Acceso permitido");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }
            Console.ReadKey();
        }
    }
}
