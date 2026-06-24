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
            string[] Asientos = new string[81];
            string[] Ocupados = new string[81];
            for (int i = 0; i <= 80; i++)
            {
                Asientos[i] = i.ToString();
            }   
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Menu Principal - AvengersAir de Buenos Aires a Wakanda");
            Console.WriteLine("---------------------------------------------------------\n");
            Console.WriteLine("Asientos Disponibles: 80\nAsientos ocupados: 0\n\n1 - Vender asiento\n2 - Devolver asiento\n3 - Modificar asiento");
            Console.WriteLine("4 - Calcular ventas\n5 - Buscar pasajeros por edad\n6 - Obtener asientos con DNI par\n7 - Salir\n");
            Console.WriteLine(" ");
            Console.Write("Ingrese la opcion deseada - ");
            int opciones = int.Parse(Console.ReadLine());
            switch (opciones)
            {
                case 1:
                    Console.WriteLine("Seleccione un asiento");
                    Console.WriteLine("Asientos de primera clase disponibles:");
                    for (int i = 0; i <= 20; i++) { if (Asientos[i] != " ") { Console.Write(Asientos[i] + " "); } }
                    Console.WriteLine();
                    Console.WriteLine("Asientos de salida de emergencia disponibles:");
                    for (int i = 40; i <= 43; i++) { if (Asientos[i] != " ") { Console.Write(Asientos[i] + " "); } }
                    Console.WriteLine();
                    Console.WriteLine("Asientos de clase economica disponibles:");
                    for (int i = 21; i <= 39; i++) { if (Asientos[i] != " ") { Console.Write(Asientos[i] + " "); } }
                    for (int i = 44; i <= 80; i++) { if (Asientos[i] != " ") { Console.Write(Asientos[i] + " "); } }
                    Console.WriteLine(" ");
                    int RespuestaC1 = int.Parse(Console.ReadLine());
                    int Nroasiento = RespuestaC1;
                    Ocupados[RespuestaC1] = Asientos[RespuestaC1];
                    Asientos[RespuestaC1] = " ";
                    
                    Console.WriteLine(" ");

                    if (RespuestaC1 <= 20)
                    {
                        Ocupados[RespuestaC1] = Ocupados[RespuestaC1] + "- Primera clase";
                    }
                    else if (RespuestaC1 >= 40 && RespuestaC1 <= 43)
                    {
                        Ocupados[RespuestaC1] = Ocupados[RespuestaC1] + "- Salida de emergencia";
                    }
                    else
                    {
                        Ocupados[RespuestaC1] = Ocupados[RespuestaC1] + "- Clase economica";
                    }
                    Console.WriteLine("Ingrese su ");

                    for(int i = 1; i <= 6;)
                    {
                        bool LetraCheck = true;
                        if (i == 1) { Console.Write("nombre: "); }
                        else if (i == 2) { Console.Write("apellido: "); }
                        else if (i == 3) { Console.Write("edad: "); }
                        else if (i == 4) { Console.Write("DNI: "); }
                        else if (i == 5) { Console.Write("Nacionalidad: "); }
                        else if (i == 6) { Console.Write("Estado de ocupacion: "); }
                        string RespuestaC11 = Console.ReadLine();
                        foreach (char caracter in RespuestaC11)
                        {
                            if (!char.IsLetter(caracter))
                            {
                                LetraCheck = false;
                                break;
                            }
                        }
                        if (i == 1 && LetraCheck == false|| i == 2 && LetraCheck == false || i == 5 && LetraCheck == false || i == 6 && LetraCheck == false)
                        {

                        }
                        Ocupados[Nroasiento] = Ocupados[Nroasiento] + "|" + Console.ReadLine();
                    }
                    Console.WriteLine(Ocupados[Nroasiento]);
                    Console.ReadKey();
                    break;
            }
        }
    }
}
