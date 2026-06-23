using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___AvengersAir
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] PrimClase = new int[21];
            int[] Salemergencia = new int[7];
            int[] Economico = new int[80 - 24];
            int a = 0; int b = 0;
            for (int i = 0; i <= 80; i++)
            {
                if (i <= 20)
                {
                    PrimClase[i] = i;
                }
                else if (i >= 40 && i <= 43)
                {
                    Salemergencia[a] = i; a++;
                }
                else
                {
                    Economico[b] = i; b++;
                }
            }
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Menu Principal - AvengersAir de Buenos Aires a Wakanda");
            Console.WriteLine("---------------------------------------------------------\n");
            Console.WriteLine("Asientos Disponibles: 80\nAsientos ocupados: 0\n\n1 - vender asiento\n2 - Devolver asiento\n3- Modificar asiento");
            Console.WriteLine("4 - Calcular ventas\n5 - Buscar pasajeros por edad\n6 - Obtener asientos con DNI par\n7 - Salir\n");
            Console.WriteLine("Asientos de primera clase disponibles:");
            for (int i = 0; i <= PrimClase.Length - 1; i++) { Console.Write(PrimClase[i] + " "); } Console.WriteLine();
            Console.WriteLine("Asientos de salida de emergencia disponibles:");
            for (int i = 0; i <= Salemergencia.Length - 1; i++) { Console.Write(Salemergencia[i] + " "); } Console.WriteLine();
            Console.WriteLine("Asientos de clase economica disponibles:");
            for (int i = 0; i <= Economico.Length - 1; i++) { Console.Write(Economico[i] + " "); } Console.WriteLine();
            Console.ReadKey();
        }
    }
}
