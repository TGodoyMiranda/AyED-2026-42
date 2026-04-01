using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_SueldoTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de horas que trabaja: ");
            double HorasTrabajo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de dinero que gana por hora: ");
            double SalarioxHora = int.Parse(Console.ReadLine());
            double Salario_Total = HorasTrabajo * SalarioxHora;
            Console.Write("Su salario total es de " + "$" + Salario_Total);
            Console.ReadKey();
        }
    }
}
