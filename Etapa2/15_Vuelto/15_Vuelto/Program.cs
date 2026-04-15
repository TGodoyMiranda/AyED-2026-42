using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Vuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el monto total de la compra ");
            int montototal = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el monto que paga ");
            int dinerototal = int.Parse(Console.ReadLine());
            int resto = dinerototal - montototal;
            int C10000 = 0, C2000 = 0, C1000 = 0, C500 = 0, C200 = 0, C100 = 0;
            int C50 = 0, C20 = 0, C10 = 0, C1 = 0;
            while (resto > 0)
            {
                if (resto >= 10000) {resto -= 10000; C10000++;}
                else if (resto >= 2000) {resto -= 2000; C2000++;}
                else if (resto >= 1000) {resto -= 1000; C1000++;}
                else if (resto >= 500) {resto -= 500; C500++;}
                else if (resto >= 200) {resto -= 200; C200++;}
                else if (resto >= 100) {resto -= 100; C100++;}
                else if (resto >= 50) {resto -= 50; C50++;}
                else if (resto >= 20) {resto -= 20; C20++;}
                else if (resto >= 10) { resto -= 10; C10++;}
                else {resto -= 1; C1++;}
            }
            Console.WriteLine("Necesitaras devolver el vuelto con:");
            if (C10000 != 0 && C10000 != 1) Console.WriteLine(C10000 + " billetes de 10000"); else if (C10000 == 1) Console.WriteLine(C10000 + " billete de 10000");
            if (C2000 != 0 && C2000 != 1) Console.WriteLine(C2000 + " billetes de 2000"); else if (C2000 == 1) Console.WriteLine(C2000 + " billete de 2000");
            if (C1000 != 0 && C1000 != 1) Console.WriteLine(C1000 + " billetes de 1000"); else if (C1000 == 1) Console.WriteLine(C1000 + " billete de 1000");
            if (C500 != 0 && C500 != 1) Console.WriteLine(C500 + " billetes de 500"); else if (C500 == 1) Console.WriteLine(C500 + " billete de 500");
            if (C200 != 0 && C200 != 1) Console.WriteLine(C200 + " billetes de 200"); else if (C200 == 1) Console.WriteLine(C200 + " billete de 200");
            if (C100 != 0 && C100 != 1) Console.WriteLine(C100 + " billetes de 100"); else if (C100 == 1) Console.WriteLine(C100 + " billete de 100");
            if (C50 != 0 && C50 != 1) Console.WriteLine(C50 + " billetes de 50"); else if (C50 == 1) Console.WriteLine(C50 + " billete de 50");
            if (C20 != 0 && C20 != 1) Console.WriteLine(C20 + " billetes de 20"); else if (C20 == 1) Console.WriteLine(C20 + " billete de 20");
            if (C10 != 0 && C10 != 1) Console.WriteLine(C10 + " billetes de 10"); else if (C10 == 1) Console.WriteLine(C10 + " billete de 10");
            if (C1 != 0 && C1 != 1) Console.WriteLine(C1 + " billetes de 1"); else if (C1 == 1) Console.WriteLine(C1 + " billete de 1");
            Console.ReadKey();
        }
    }
}
