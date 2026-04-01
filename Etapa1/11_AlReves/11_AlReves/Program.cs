using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte 3 letras aqui: ");
            string Letras = Console.ReadLine();
            char[] ArrayLetras = Letras.ToArray();
            Array.Reverse(ArrayLetras);
            String Letras_invertidas = new string(ArrayLetras);
            Console.WriteLine("Sus letras invertidas son: " + Letras_invertidas);
            Console.ReadKey();
        }
    }
}
