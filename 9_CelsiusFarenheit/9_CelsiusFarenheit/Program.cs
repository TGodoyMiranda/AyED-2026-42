using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CelsiusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte una temperatura en grados Celsius: ");
            float Celsius = int.Parse(Console.ReadLine());
            float Fahrenheit = Celsius * 1.8f + 32;
            float Kelvin = Celsius + 273.15f;
            Console.WriteLine("La temperatura " + Celsius + "°C " + "convertida a Fahrenheit es: " + Fahrenheit + "°F");
            Console.WriteLine("La temperatura " + Celsius + "°C " + "insertada convertida a Kelvin es: " + Kelvin + "°K");
            Console.ReadKey();
        }
    }
}
