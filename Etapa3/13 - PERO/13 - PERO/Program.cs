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
            int[,] Misiones = new int[30,2];
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
                        Console.WriteLine("Ingrese la ID de la mision: ");
                        int IDMision = int.Parse(Console.ReadLine());
                        Misiones[i, 1] = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        // Punto 2: Ver todas las misiones
                        break;
                    case 3:
                        // Punto 3: Cambiar estado de misión
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
