using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_NombreCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte su nombre aqui: ");
            string Nombre = Console.ReadLine();
            Console.Write("Inserte su apellido aqui: ");
            String Apellido = Console.ReadLine();
            Console.Write("Su nombre y apellido es: " + Nombre + " " + Apellido);
            Console.ReadKey();
        }
    }
}
