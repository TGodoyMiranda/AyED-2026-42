using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ConversorMetrosCentimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte su medida en metros aqui: ");
            double Metros = int.Parse(Console.ReadLine());
            double Centimetros = Metros * 100;
            double Milimetros = Metros * 1000;
            Console.WriteLine("Su medida en Centimetros es " + Centimetros + "cm");
            Console.Write("Su medida en Milimetros es " + Milimetros + "mm");
            Console.ReadKey();
        }
    }
}
