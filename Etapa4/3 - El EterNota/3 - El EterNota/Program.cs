using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___El_EterNota
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int NumRefugio = 0;
            int Filas = 20, Columnas = 5;
            int[,] RefugioYdatos = new int[Filas, Columnas]; // Donde 20 son los refugios y 5 los tipos de dato;
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("==== MENÚ DEL ETERNOTA ====");
                Console.WriteLine("1. Agregar refugio");
                Console.WriteLine("2. Mostrar todos los refugios");
                Console.WriteLine("3. Ocupar refugio");
                Console.WriteLine("4. Mostrar ocupados");
                Console.WriteLine("5. Refugio con más suministros");
                Console.WriteLine("6. Promedio por zona");
                Console.WriteLine("7. Filtrar por zona");
                Console.WriteLine("8. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        int CapMax = 0; int Suministros = 0; int Zona = 0; int Ocupado = 0;
                        while (true)
                        {
                            Console.Write("Ingrese la capacidad maxima: ");
                            CapMax = int.Parse(Console.ReadLine());
                            if (CapMax <= 0)
                            {
                                Console.Write("No se puede sobrevivir debiendo...");
                                Console.ReadKey();
                                EliminarLineactual(2);
                            }
                            else
                            {
                                break;
                            }
                        }
                        while (true)
                        {
                            Console.Write("Ingrese suministros: ");
                            Suministros = int.Parse(Console.ReadLine());
                            if (Suministros <= 0)
                            {
                                Console.WriteLine("No se puede sobrevivir debiendo...");
                                Console.ReadKey();
                                EliminarLineactual(2);
                            }
                            else
                            {
                                break;
                            }
                        }
                        while (true)
                        {
                            Console.Write("Ingrese la zona: ");
                            Zona = int.Parse(Console.ReadLine());
                            if (Zona != 1 && Zona != 2 && Zona != 3 && Zona != 4)
                            {
                                Console.WriteLine("Zona invàlida, esa parte ya està perdida");
                                Console.ReadKey();
                                EliminarLineactual(2);
                            }
                            else
                            {
                                break;
                            }
                        }
                        while (true)
                        {
                            Console.Write("Ingrese estado de ocupacion: ");
                            Ocupado = int.Parse(Console.ReadLine());
                            if (Ocupado != 0 && Ocupado != 1)
                            {
                                Console.WriteLine("Estado invalido");
                                Console.ReadKey();
                                EliminarLineactual(2);
                            }
                            else
                            {
                                break;
                            }
                        }
                        NumRefugio++;
                        Console.WriteLine("Registrado exitosamente");
                        AgregarRefugio(NumRefugio, CapMax, Suministros, Zona, Ocupado, RefugioYdatos);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        MostrarRefugio(RefugioYdatos);
                        Console.ReadKey();
                        break;
                    case 3:
                        OcuparRefugio(RefugioYdatos);
                        Console.ReadKey();
                        break;
                    case 4:
                        MostrarOcupados(RefugioYdatos);
                        Console.ReadKey();
                        break;
                    case 5:
                        MasSuministros(RefugioYdatos);
                        Console.ReadKey();
                        break;
                    case 6:
                        PromedioZona(RefugioYdatos);
                        Console.ReadKey();
                        break;
                    case 7:
                        FiltrarZona(RefugioYdatos);
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Que la nevada no te atrape!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            } while (opcion != 8);
        }

        // ====================================================
        // MÉTODOS FUERA DEL MAIN (UNIFICADOS Y CORREGIDOS)
        // ====================================================

        static void AgregarRefugio(int NroRefugio, int capacidadMax, int Suministros, int Zona, int ocupacion, int[,] RegistroMatriz)
        {
            int Columnas = RegistroMatriz.GetLength(1);
            int i = NroRefugio - 1;

            for (int j = 0; j < Columnas; j++)
            {
                if (j == 0) RegistroMatriz[i, j] = NroRefugio;
                else if (j == 1) RegistroMatriz[i, j] = capacidadMax;
                else if (j == 2) RegistroMatriz[i, j] = Suministros;
                else if (j == 3) RegistroMatriz[i, j] = Zona;
                else if (j == 4) RegistroMatriz[i, j] = ocupacion;
            }
        }

        static void MostrarRefugio(int[,] RegistroMatriz)
        {
            Console.WriteLine("\nNro | Cap. Max | Suministros | Zona | Ocupado");
            Console.WriteLine("---------------------------------------------");
            for (int i = 0; i < RegistroMatriz.GetLength(0); i++)
            {
                if (RegistroMatriz[i, 0] > 0)
                {
                    for (int j = 0; j < RegistroMatriz.GetLength(1); j++)
                    {
                        Console.Write(RegistroMatriz[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void OcuparRefugio(int[,] RegistroMatriz)
        {
            Console.Write("Ingrese el numero de refugio: ");
            int NroRefugio = int.Parse(Console.ReadLine());
            int fila = NroRefugio - 1;

            if (fila >= 0 && fila < RegistroMatriz.GetLength(0) && RegistroMatriz[fila, 0] > 0)
            {
                if (RegistroMatriz[fila, 4] == 1)
                {
                    Console.WriteLine("Ya esta ocupado");
                }
                else
                {
                    RegistroMatriz[fila, 4] = 1;
                    Console.WriteLine("El refugio ahora se encuentra ocupado.");
                }
            }
            else
            {
                Console.WriteLine("Refugio no encontrado o inexistente.");
            }
        }

        static void MostrarOcupados(int[,] RegistroMatriz)
        {
            Console.WriteLine("\n=== REFUGIOS ACTUALMENTE OCUPADOS ===");
            bool algunoOcupado = false;

            for (int i = 0; i < RegistroMatriz.GetLength(0); i++)
            {
                if (RegistroMatriz[i, 0] > 0 && RegistroMatriz[i, 4] == 1)
                {
                    algunoOcupado = true;
                    for (int j = 0; j < RegistroMatriz.GetLength(1); j++)
                    {
                        Console.Write(RegistroMatriz[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            if (algunoOcupado == false)
            {
                Console.WriteLine("No hay refugios ocupados.");
            }
        }

        static void MasSuministros(int[,] RegistroMatriz)
        {
            int maxSuministros = -1;
            int nroRefugioMax = 0;

            for (int i = 0; i < RegistroMatriz.GetLength(0); i++)
            {
                if (RegistroMatriz[i, 0] > 0)
                {
                    // Columna 2 = Suministros
                    if (RegistroMatriz[i, 2] > maxSuministros)
                    {
                        maxSuministros = RegistroMatriz[i, 2];
                        nroRefugioMax = RegistroMatriz[i, 0];
                    }
                }
            }

            if (nroRefugioMax > 0)
            {
                Console.WriteLine("=============================");
                Console.WriteLine("REFUGIO CON MÁS SUMINISTROS");
                Console.WriteLine("=============================");
                Console.WriteLine("El refugio con más suministros es el Nro: " + nroRefugioMax + " con " + maxSuministros + " unidades.");
            }
            else
            {
                Console.WriteLine("No hay refugios registrados en el sistema.");
            }
        }

        static void PromedioZona(int[,] RegistroMatriz)
        {
            double[] promedios = new double[4];

            for (int k = 1; k <= 4; k++)
            {
                double sumatoria = 0;
                int contadorRefugios = 0;

                for (int i = 0; i < RegistroMatriz.GetLength(0); i++)
                {
                    // Columna 3 = Zona
                    if (RegistroMatriz[i, 0] > 0 && RegistroMatriz[i, 3] == k)
                    {
                        sumatoria = sumatoria + RegistroMatriz[i, 1]; // Capacidad Máxima (Columna 1)
                        contadorRefugios++;
                    }
                }

                if (contadorRefugios > 0)
                {
                    promedios[k - 1] = sumatoria / contadorRefugios;
                }
                else
                {
                    promedios[k - 1] = 0;
                }
            }

            Console.WriteLine("============\nPROMEDIO ZONA\n============\n");
            Console.WriteLine("Zona 1: " + promedios[0] + "\nZona 2: " + promedios[1] + "\nZona 3: " + promedios[2] + "\nZona 4: " + promedios[3]);
        }

        static void FiltrarZona(int[,] RegistroMatriz)
        {
            Console.Write("Elige Zona (1 a 4): ");
            string Zona = Console.ReadLine();
            bool Hay = false;
            int zonaElegida = int.Parse(Zona);
            Console.WriteLine("\n=== REFUGIOS EN LA ZONA " + zonaElegida + " ===");
            for (int i = 0; i < RegistroMatriz.GetLength(0); i++)
            {
                if (RegistroMatriz[i, 0] > 0 && RegistroMatriz[i, 3] == zonaElegida)
                {
                    Hay = true;
                    for (int j = 0; j < RegistroMatriz.GetLength(1); j++)
                    {
                        Console.Write(RegistroMatriz[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            if (Hay == false)
            {
                Console.WriteLine("No hay Refugios en esta zona");
            }
        }
        static void EliminarLineactual(int Repeticiones)
        {
            int Lineacomienzo = Console.CursorTop;
            int Ultimalineaborrada = Lineacomienzo;
            for (int i = 0; i < Repeticiones; i++)
            {
                int targetLine = Lineacomienzo - i;
                if (targetLine >= 0)
                {
                    Console.SetCursorPosition(0, targetLine);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Ultimalineaborrada = targetLine;
                }
            }
            Console.SetCursorPosition(0, Ultimalineaborrada);
        }
    }
}
