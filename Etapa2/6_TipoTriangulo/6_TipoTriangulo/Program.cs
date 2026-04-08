using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TipoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un angulo 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un angulo 'b': ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un angulo 'c': ");
            int c = int.Parse(Console.ReadLine());
            if (a + b > c) {
                if (a == b && a != c || c == b && c != a || c == a  && c != b)
                {
                    Console.WriteLine("Es un triangulo valido tipo Isosceles");

                }
                else if (a == b && a == c || c == b && c == a || b == c && b == a)
                {
                    Console.WriteLine("Es un triangulo valido tipo Equilitatero");
                }
                else
                {
                    Console.WriteLine("Es un triangulo valido tipo Escaleno");
                }
            }
            else
            {
                Console.WriteLine("No es un triangulo valido");
            }
            Console.ReadKey();
        }
    }
}
