using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PresupuestoHospitalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su presupuesto anual total: ");
            double Presupuesto = int.Parse(Console.ReadLine());
            double Area_Ginecologia = (Presupuesto * 40) / 100;
            double Area_TraumaPedria = (Presupuesto * 30) / 100;
            Console.WriteLine("El area de ginecologia recibe " + "$" + Area_Ginecologia);
            Console.WriteLine("El area de traumatologia recibe " + "$" + Area_TraumaPedria);
            Console.Write("El area de pediatria recibe " + "$" + Area_TraumaPedria);
            Console.ReadKey();
        }
    }
}
