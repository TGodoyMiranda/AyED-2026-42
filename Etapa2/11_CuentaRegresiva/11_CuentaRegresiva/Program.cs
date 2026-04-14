using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            int num = numero;
            while (num > -1)
            {
                Console.WriteLine(num);
                num -= 1;
            }
            Console.ReadKey();
        }
    }
}
