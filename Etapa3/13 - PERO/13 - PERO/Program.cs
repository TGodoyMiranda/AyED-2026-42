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
                Console.WriteLine("6. Promedio de pegrilo por mapa");
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
                        for (int j = 0; j <= 30; j++)
                        {
                            if (Misiones[j, 0] == -1)
                            {
                                break;
                            }
                            else
                            {
                                for (int l = 0; l < 5; l++)
                                {
                                    Console.Write(Misiones[j, l] + " | ");
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
                            if (IDBusqueda == Misiones[j, 1])
                            {
                                if (Misiones[j, 5] == 2)
                                {
                                    Misiones[j, 5] = 0;
                                }
                                else
                                {
                                    Misiones[j, 5] = Misiones[j, 5] + 1;
                                }
                            }
                        }
                        break;
                    case 4:
                        // Punto 4: Listar misiones en curso
                        break;
                    case 5:
                        // Punto 5: Misión con más objetos a extraer
                        break;
                    case 6:
                        // Punto 6: Promedio de peligro por mapa
                        break;
                    case 7:
                        // Punto 7: Filtrar por mapa
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
