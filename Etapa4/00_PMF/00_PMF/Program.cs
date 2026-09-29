using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Modular
{
    class Program
    {
        static void Main(string[] args)
        {
            SaludarA("aaaa");
            int a = 3, b = 5, c = 2;
            Console.WriteLine(Sumar(5, 3));
            Console.WriteLine(Sumar(3, 2));
            Console.WriteLine(Sumar(Sumar(b, a), Sumar(a, c)));
            Console.WriteLine(Sumar(Sumar(a, SumarDos(Sumar(c, b))), a));
            Console.ReadKey();
        }
        static void SaludarA(String Nombre)
        {
            Console.WriteLine("Hola " + Nombre);
        }
        static int SumarDos(int n)
        {
            int resultado = n + 2;
            return resultado;
        }
        static int Sumar(int n, int n2)
        {
            int resultado = n + n2;
            return resultado;
        }
    }
}
