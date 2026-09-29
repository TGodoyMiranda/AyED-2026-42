using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___PERO
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Misiones = new int[30,5];
            for (int j = 0; j < 30; j++)
            {
                for (int l = 0; l < 5; l++)
                {
                    Misiones[j, l] = -1;
                }
            }
            int i = 0;
            Random rand = new Random();
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("==== MENÚ DEL P.E.R.O. ====");
                Console.WriteLine("1. Registrar nueva misión");
                Console.WriteLine("2. Ver todas las misiones");
                Console.WriteLine("3. Cambiar estado de una misión");
                Console.WriteLine("4. Listar misiones en curso");
                Console.WriteLine("5. Misión con más objetos a extraer");
                Console.WriteLine("6. Promedio de peligro por mapa");
                Console.WriteLine("7. Filtrar por mapa");
                Console.WriteLine("8. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        // Punto 1: Registrar nueva misión
                        int Respuesta;
                        Console.WriteLine("Ingrese la ID de la mision: ");
                        Respuesta = int.Parse(Console.ReadLine());
                        Misiones[i, 0] = Respuesta; Respuesta = 0;
                        while (Respuesta != 1 && Respuesta != 2 && Respuesta != 3)
                        {
                            Console.Write("Ingrese el mapa: ");
                            Respuesta = int.Parse(Console.ReadLine());
                            if (Respuesta != 1 && Respuesta != 2 && Respuesta != 3)
                            {
                                Console.WriteLine("Ese mapa no es de este juegazo");
                                Console.ReadKey();
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                                Console.SetCursorPosition(0, Console.CursorTop - 2);
                                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                            }
                        }
                        Misiones[i, 1] = Respuesta; Respuesta = 0;
                        Misiones[i, 2] = rand.Next(1, 71); Respuesta = 0;
                        while (Respuesta != 1 && Respuesta != 2 && Respuesta != 3 && Respuesta != 4 && Respuesta != 5)
                        {
                            Console.Write("Ingrese la dificultad de la mision: ");
                            Respuesta = int.Parse(Console.ReadLine());
                            if (Respuesta != 1 && Respuesta != 2 && Respuesta != 3 && Respuesta != 4 && Respuesta != 5)
                            {
                                Console.WriteLine(" - Este nivel es demasiado PEGRILOSO...");
                                Console.ReadKey();
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                                Console.SetCursorPosition(0, Console.CursorTop - 2);
                                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                            }
                        }
                        Misiones[i, 3] = Respuesta; Respuesta = 0;
                        while (Respuesta != 1 && Respuesta != 2 && Respuesta != 3)
                        {
                            Console.Write("El estado de la mision: ");
                            Respuesta = int.Parse(Console.ReadLine());
                            if (Respuesta != 1 && Respuesta != 2 && Respuesta != 3)
                            {
                                Console.WriteLine(" - No es un estado valido");
                                Console.ReadKey();
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                                Console.SetCursorPosition(0, Console.CursorTop - 2);
                                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                            }
                        }
                        Misiones[i, 4] = Respuesta; Respuesta = 0;
                        Console.WriteLine("Mision registrada correctamente");
                        i++;
                        break;
                    case 2:
                        // Punto 2: Ver todas las misiones
                        for (int j = 0; j < 30; j++)
                        {
                            if (Misiones[j, 0] == -1)
                            {
                                break;
                            }
                            else
                            {
                                int k = 0;
                                for (int h = 0; h < 5; h++)

                                {
                                    if (k == 0) { Console.Write("ID: "); }
                                    else if (k == 1) { Console.Write("Mapa: "); }
                                    else if (k == 2) { Console.Write("Objetos a extraer: "); }
                                    else if (k == 3) { Console.Write("Nivel de peligro: "); }
                                    else if (k == 4) { Console.Write("Estado: "); }
                                    Console.Write(Misiones[j, h] + " | ");
                                    k++;
                                }
                                Console.WriteLine("");
                            }
                        }
                        break;
                    case 3:
                        // Punto 3: Cambiar estado de misión
                        Console.Write("Cual es la ID de tu mision? ");
                        int IDBusqueda = int.Parse(Console.ReadLine());
                        for (int j = 0; j < 30; j++)
                        {
                            if (IDBusqueda == Misiones[j, 0])
                            {
                                if (Misiones[j, 4] == 3)
                                {
                                    Misiones[j, 4] = 1;
                                }
                                else
                                {
                                    Misiones[j, 4] = Misiones[j, 4] + 1;
                                }
                            }
                        }
                        break;
                    case 4:
                        // Punto 4: Listar misiones en curso
                        Console.WriteLine("Misiones en curso: ");
                        for (int j = 0; j < 30; j++)
                        {
                            if (Misiones[j, 4] == 1)
                            {
                                int k = 0;
                                for (int h = 0; h < 5; h++)

                                {
                                    if (k == 0) { Console.Write("ID: "); }
                                    else if (k == 1) { Console.Write("Mapa: "); }
                                    else if (k == 2) { Console.Write("Objeto a extraer: "); }
                                    else if (k == 3) { Console.Write("Nivel de peligro: "); }
                                    else if (k == 4) { Console.Write("Estado: "); }
                                    Console.Write(Misiones[j, h] + " | ");
                                    k++;
                                }
                                Console.WriteLine("");
                            }
                        }
                            break;
                    case 5:
                        int max_mision_index = 0;
                        int max_objetos = Misiones[0, 2];
                        Console.WriteLine("Misión con más objetos a extraer:");
                        for (int m = 1; m < 30; m++)
                        {
                            if (Misiones[m, 2] > max_objetos)
                            {
                                max_objetos = Misiones[m, 2];
                                max_mision_index = m;
                            }
                        }
                        Console.WriteLine("Mision " + max_mision_index + " con un total de " + max_objetos + " objetos.");
                        break;

                    case 6:
                        // Punto 6: Promedio de peligro por mapa
                        int max_mapas = 30;
                        int[] suma_peligro = new int[max_mapas];
                        int[] cantidad_misiones = new int[max_mapas];

                        for (int m = 0; m < 30; m++)
                        {
                            int mapa = Misiones[m, 1];
                            int peligro = Misiones[m, 3];
                            if (mapa >= 0 && mapa < max_mapas)
                            {
                                suma_peligro[mapa] += peligro;
                                cantidad_misiones[mapa]++;
                            }
                        }
                        Console.WriteLine("Promedio de peligro por mapa:");
                        for (int k = 0; k < max_mapas; k++)
                        {
                            if (cantidad_misiones[k] > 0)
                            { double promedio = (double)suma_peligro[k] / cantidad_misiones[k]; Console.WriteLine("- Mapa " + k + ": Promedio de peligro = " + promedio.ToString("F2")); }
                        }
                        break;


                    case 7:
                        // Punto 7: Filtrar por mapa
                        Console.Write("Ingrese el número de mapa para filtrar: ");
                        int mapa_buscado = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nMisiones encontradas en el mapa " + mapa_buscado + ":");
                        bool encontro_misiones = false;

                        for (int m = 0; m < 30; m++)
                        {
                            if (Misiones[m, 1] == mapa_buscado) { Console.WriteLine("- Misión " + m + ": " + Misiones[m, 2] + " objetos a extraer."); encontro_misiones = true; }
                        }
                        if (!encontro_misiones) { Console.WriteLine("No se encontraron misiones registradas para el mapa " + mapa_buscado + "."); }
                        break;
                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Esperemos que el PERO no sea letal!");
                break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 8);
        }
    }
}
