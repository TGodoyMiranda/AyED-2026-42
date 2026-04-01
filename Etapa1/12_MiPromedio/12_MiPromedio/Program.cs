using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MiPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte un numero: ");
            int Numero = int.Parse(Console.ReadLine());
            Console.Write("Inserte segundo numero: ");
            int Numero2 = int.Parse(Console.ReadLine());
            Console.Write("Inserte tercer numero: ");
            int Numero3 = int.Parse(Console.ReadLine());
            float Promedio = (Numero + Numero2 + Numero3) / 3;
            Console.Write("El promedio de tus 3 Numeros es: " + Promedio);
            Console.ReadKey();
        }
    }
}
