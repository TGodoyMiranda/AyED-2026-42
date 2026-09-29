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

            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                int cantDisponibles = 0;
                int cantOcupados = 0;
                for (int i = 0; i <= 80; i++)
                {
                    if (Asientos[i] == " ") cantOcupados++;
                    else cantDisponibles++;
                }

                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Menu Principal - AvengersAir de Buenos Aires a Wakanda");
                Console.WriteLine("---------------------------------------------------------\n");
                Console.WriteLine("Asientos Disponibles: " + cantDisponibles + "\nAsientos ocupados: " + cantOcupados + "\n");
                Console.WriteLine("1 - Vender asiento\n2 - Devolver asiento\n3 - Modificar asiento");
                Console.WriteLine("4 - Calcular ventas\n5 - Buscar pasajeros por edad\n6 - Obtener asientos con DNI par\n7 - Salir\n");
                Console.WriteLine(" ");
                Console.Write("Ingrese la opcion deseada - ");

                int opciones;
                if (!int.TryParse(Console.ReadLine(), out opciones)) continue;

                switch (opciones)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Seleccione un asiento");
                        Console.WriteLine("Asientos de primera clase disponibles:");
                        for (int i = 0; i <= 20; i++) { if (Asientos[i] != " ") { Console.Write(Asientos[i] + " "); } }
                        Console.WriteLine();
                        Console.WriteLine("Asientos de salida de emergencia disponibles:");
                        for (int i = 40; i <= 43; i++) { if (Asientos[i] != " ") { Console.Write(Asientos[i] + " "); } }
                        Console.WriteLine();
                        Console.WriteLine("Asientos de clase economica disponibles:");
                        for (int i = 21; i <= 39; i++) { if (Asientos[i] != " ") { Console.Write(Asientos[i] + " "); } }
                        Console.WriteLine();
                        for (int i = 44; i <= 80; i++) { if (Asientos[i] != " ") { Console.Write(Asientos[i] + " "); } }
                        Console.WriteLine("\n ");

                        Console.Write("Ingrese el numero de asiento: ");
                        int RespuestaC1 = int.Parse(Console.ReadLine());
                        int Nroasiento = RespuestaC1;

                        if (RespuestaC1 < 0 || RespuestaC1 > 80 || Asientos[RespuestaC1] == " ")
                        {
                            Console.WriteLine("Asiento no valido o ya ocupado.");
                            Console.ReadKey();
                            break;
                        }

                        Ocupados[RespuestaC1] = Asientos[RespuestaC1];
                        Asientos[RespuestaC1] = " ";

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

                        Console.WriteLine("Ingrese sus datos:");

                        for (int i = 1; i <= 6; i++)
                        {
                            bool LetraCheck = true;
                            string etiqueta = "";
                            if (i == 1) { etiqueta = "nombre: "; }
                            else if (i == 2) { etiqueta = "apellido: "; }
                            else if (i == 3) { etiqueta = "edad: "; }
                            else if (i == 4) { etiqueta = "DNI: "; }
                            else if (i == 5) { etiqueta = "Nacionalidad: "; }
                            else if (i == 6) { etiqueta = "Estado de ocupacion: "; }

                            string RespuestaC11 = "";
                            while (true)
                            {
                                Console.Write(etiqueta);
                                RespuestaC11 = Console.ReadLine();
                                LetraCheck = true;
                                if (i == 1 || i == 2 || i == 5 || i == 6)
                                {
                                    foreach (char caracter in RespuestaC11)
                                    {
                                        if (!char.IsLetter(caracter) && caracter != ' ')
                                        {
                                            LetraCheck = false;
                                            break;
                                        }
                                    }
                                }

                                if (LetraCheck && !string.IsNullOrEmpty(RespuestaC11)) break;
                                Console.WriteLine("Dato invalido, intente de nuevo.");
                            }

                            Ocupados[Nroasiento] = Ocupados[Nroasiento] + "|" + RespuestaC11;
                        }
                        Console.WriteLine("\nPasajero registrado: " + Ocupados[Nroasiento]);
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("--- Devolver Asiento ---");
                        Console.Write("Ingrese el numero de asiento a devolver: ");
                        int asientoDevolver = int.Parse(Console.ReadLine());

                        if (asientoDevolver >= 0 && asientoDevolver <= 80 && Asientos[asientoDevolver] == " ")
                        {
                            Ocupados[asientoDevolver] = null;
                            Asientos[asientoDevolver] = asientoDevolver.ToString();
                            Console.WriteLine("Asiento devuelto exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("El asiento no esta ocupado o no es valido.");
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("--- Modificar Asiento ---");
                        Console.Write("Ingrese el numero de asiento a modificar: ");
                        int asientoModificar = int.Parse(Console.ReadLine());

                        if (asientoModificar >= 0 && asientoModificar <= 80 && Ocupados[asientoModificar] != null)
                        {
                            Console.WriteLine("Datos actuales: " + Ocupados[asientoModificar]);
                            string[] datos = Ocupados[asientoModificar].Split('|');
                            Console.Write("Nuevo Nombre: ");
                            datos[1] = Console.ReadLine();
                            Console.Write("Nuevo Apellido: ");
                            datos[2] = Console.ReadLine();
                            Console.Write("Nueva Edad: ");
                            datos[3] = Console.ReadLine();
                            Console.Write("Nuevo DNI: ");
                            datos[4] = Console.ReadLine();
                            Console.Write("Nueva Nacionalidad: ");
                            datos[5] = Console.ReadLine();
                            Console.Write("Nuevo Estado de ocupacion: ");
                            datos[6] = Console.ReadLine();
                            Ocupados[asientoModificar] = datos[0] + "|" + datos[1] + "|" + datos[2] + "|" + datos[3] + "|" + datos[4] + "|" + datos[5] + "|" + datos[6];
                            Console.WriteLine("Datos modificados correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Asiento no ocupado o invalido.");
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("--- Calcular Ventas ---");
                        int totalPrimera = 0, totalEmergencia = 0, totalEconomica = 0;

                        for (int i = 0; i <= 80; i++)
                        {
                            if (Ocupados[i] != null)
                            {
                                if (Ocupados[i].Contains("Primera clase")) totalPrimera++;
                                else if (Ocupados[i].Contains("Salida de emergencia")) totalEmergencia++;
                                else if (Ocupados[i].Contains("Clase economica")) totalEconomica++;
                            }
                        }
                        Console.WriteLine("Cantidad Primera Clase: " + totalPrimera);
                        Console.WriteLine("Cantidad Salida Emergencia: " + totalEmergencia);
                        Console.WriteLine("Cantidad Clase Economica: " + totalEconomica);
                        Console.WriteLine("Total de asientos vendidos: " + (totalPrimera + totalEmergencia + totalEconomica));
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("--- Buscar Pasajeros por Edad ---");
                        Console.Write("Ingrese la edad a buscar: ");
                        string edadBuscar = Console.ReadLine();
                        bool encEdad = false;
                        for (int i = 0; i <= 80; i++)
                        {
                            if (Ocupados[i] != null)
                            {
                                string[] datos = Ocupados[i].Split('|');
                                if (datos.Length > 3 && datos[3] == edadBuscar)
                                {
                                    Console.WriteLine("Asiento " + i + ": " + datos[1] + " " + datos[2]);
                                    encEdad = true;
                                }
                            }
                        }
                        if (!encEdad) Console.WriteLine("No se encontraron pasajeros con esa edad.");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("--- Obtener Asientos con DNI Par ---");
                        bool encDni = false;

                        for (int i = 0; i <= 80; i++)
                        {
                            if (Ocupados[i] != null)
                            {
                                string[] datos = Ocupados[i].Split('|');
                                if (datos.Length > 4)
                                {
                                    int dniVal;
                                    if (int.TryParse(datos[4], out dniVal))
                                    {
                                        if (dniVal % 2 == 0)
                                        {
                                            Console.WriteLine("Asiento " + i + " - Pasajero: " + datos[1] + " " + datos[2] + " | DNI Par: " + dniVal);
                                            encDni = true;
                                        }
                                    }
                                }
                            }
                        }
                        if (!encDni) Console.WriteLine("No se encontraron pasajeros con DNI par.");
                        Console.ReadKey();
                        break;
                    case 7:
                        salir = true;
                        Console.WriteLine("Saliendo del sistema de AvengersAir...");
                        break;
                }
            }
        }
    }
}
