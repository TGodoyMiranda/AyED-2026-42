using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte el ancho deseado de su rectangulo: ");
            double Ancho = int.Parse(Console.ReadLine());
            Console.Write("Inserte el alto deseado de su rectangulo: ");
            double Alto = int.Parse(Console.ReadLine());
            double Perimetro = 2 * Ancho + 2 * Alto;
            double Area = Ancho * Alto;
            double Diagonal = Math.Sqrt(Math.Pow(Ancho, 2)) + Math.Sqrt(Math.Pow(2, Alto));
            Console.WriteLine("Dado el ancho = " + Ancho + " y el alto = " + Alto + " de este rectangulo,");
            Console.WriteLine("- Su perimetro sera de " + Perimetro);
            Console.WriteLine("- Su Area sera de " + Area);
            Console.WriteLine("- Su diagonal sera de " + Diagonal);
            Console.ReadKey();
        }
    }
}
