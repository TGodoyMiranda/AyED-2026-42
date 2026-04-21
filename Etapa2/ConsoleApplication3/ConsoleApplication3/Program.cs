using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3parimpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int a = Convert.ToInt32(Console.Read());
            if (a % 2 == 1)
            {
                Console.WriteLine("El numero ingresado es impar", a);
            }
            else
            {
                if (a == 0)
                {
                    Console.WriteLine("El numero 0 tambien es par");
                }
                else
                {
                    Console.WriteLine("El numero {0} es par", a);
                }
            }
            Console.ReadKey();
        }
    }
}
