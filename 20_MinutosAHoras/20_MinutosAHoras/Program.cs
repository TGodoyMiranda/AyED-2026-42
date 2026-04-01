using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MinutosAHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una cantidad de minutos: ");
            int Minutos = int.Parse(Console.ReadLine());
            double Horas = Minutos / 60;
            double Min_restantes = Minutos % 60;
            Console.Write("Tu cantidad de minutos equivalen a: " + Horas + " horas y " + Min_restantes + " minutos.");
            Console.ReadKey();  
        }
    }
}
