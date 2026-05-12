using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 0; int cm = 0; int o = 0; int pM = 0; int cmM = 0; int oM = 0; int x = 3;
            int a = 1;
            while (a == 1)
            {
                int d = 1;
                Console.WriteLine("Ingresa tu nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingresa tu apellido");
                string apellido = Console.ReadLine();
                Console.WriteLine("Ingresa tu edad");
                int edad = Convert.ToInt32(Console.ReadLine());
                if (edad > 0 && edad <= 120)
                {
                    Console.WriteLine("Ingresa tu prestacion (CLINICA MEDICA (1), ODONTOLOGIA (2), PEDIATRIA (3))");
                    string prestacion = Console.ReadLine();
                    switch (prestacion)
                    {
                        case "1": break;
                        case "2": break;
                        case "3": break;
                        default: Console.WriteLine("No se ha registrado una prestacion(Elegir una la proxima vez)"); break;
                    }
                    Console.WriteLine("Si quiere salir escriba 0 y si no escriba cualquier otra letra");
                    string prestacion2 = Console.ReadLine();
                    if (edad >= 18 && prestacion == "3")
                    {
                        pM += 1;
                    }
                    else if (edad < 18 && prestacion == "3")
                    {
                        p += 1;
                    }
                    else if (edad >= 18 && prestacion == "2")
                    {
                        oM += 1;
                        x += 1;
                    }
                    else if (edad < 18 && prestacion == "2")
                    {
                        o += 1;
                    }
                    else if (edad >= 18 && prestacion == "1")
                    {
                        cmM += 1;
                    }
                    else if (edad < 18 && prestacion == "1")
                    {
                        cm += 1;
                    }
                    switch (prestacion2)
                    {
                        default: break;
                        case "0": Console.WriteLine("Cantidad de pacientes mayores en clinica medica: " + cmM); Console.WriteLine("Cantidad de pacientes menores en clinica medica: " + cm); Console.WriteLine("Cantidad de pacientes totales en clinica medica: " + (cmM + cm)); Console.WriteLine(""); Console.WriteLine("Cantidad de pacientes mayores en odontologia: " + oM); Console.WriteLine("Cantidad de pacientes menores en odontologia: " + o); Console.WriteLine("Cantidad de pacientes totales en odontologia: " + (oM + o)); Console.WriteLine(""); Console.WriteLine("Cantidad de pacientes menores en pediatria: " + p); Console.WriteLine("Cantidad de pacientes mayores en pediatria: " + pM); Console.WriteLine("Cantidad de pacientes totales en pediatria: " + (pM + p)); a = 2; break;
                    }
                }
                else
                {
                    Console.WriteLine("Elige una edad valida (1 - 120)");
                }
            }
            Console.ReadKey();
        }
    }
}
