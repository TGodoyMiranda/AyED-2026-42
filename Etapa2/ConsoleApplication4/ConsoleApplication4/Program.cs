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
            Console.WriteLine("¿Cual es tu edad?");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿De cuanto son tus ingresos mensuales?");
            int ingreso = Convert.ToInt32(Console.ReadLine());
            if (ingreso <0 || edad<0)
            {
                Console.WriteLine("Ingrese datos correctos la proxima vez");
            }
            if (edad > 19 && ingreso <= 100000)
            {
                Console.WriteLine("Puedas cobrar la beca");
            }
            if (edad < 19 && ingreso == 0)
            {
                Console.WriteLine("Puedas cobrar la beca");
            }
            if (edad ==19 && ingreso <=50000)
            {
                Console.WriteLine("Puedas cobrar la beca");
            }
            if ((edad >19 && ingreso >100000) || (edad<=19 &&))
            Console.ReadKey();
        }
    }
}
