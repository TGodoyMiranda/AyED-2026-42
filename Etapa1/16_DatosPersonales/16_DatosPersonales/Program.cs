using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DatosPersonales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte su nombre aqui: ");
            String Nombre = Console.ReadLine();
            Console.Write("Inserte su edad aqui: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Inserte la ciudad donde vive aqui: ");
            String Ciudad = Console.ReadLine();
            Console.Write("Su nombre es " + Nombre + " Tienes " + edad + " años y vivis en " + Ciudad);
            Console.ReadKey();


        }
    }
}
