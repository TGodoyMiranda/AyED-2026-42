using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SimuladorJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            int Vida = 10; int Hambre = 10; int Dias = 1;
            int Comida_Cruda = 0; int Comida_Cocida = 0;
            bool Refugio = false; bool Fogata = false;
            bool FinPartida = false;
            string Accion = "";
            while (FinPartida != true)
            {
                Random NumR = new Random();
                NumR.Next(1, 101);
                Console.WriteLine("----------------------------");
                Console.WriteLine("  SUPERVIVENCIA EN LA ISLA");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Dias sobrevividos: " + Dias);
                Console.WriteLine("Vida: " + Vida + "  Hambre: " + Hambre);
                if (Comida_Cruda > 0)
                {
                    Console.WriteLine("Comida Cruda" + Comida_Cruda);
                }
                if (Comida_Cocida > 0)
                {
                    Console.WriteLine("Comida" + Comida_Cocida);
                }
                if (Refugio == true && Fogata == true)
                {
                    Console.WriteLine("Posees un refugio y una fogata");
                }
                else if (Refugio == true && Fogata == false)
                {
                    Console.WriteLine("Posees un refugio.");
                }
                else if (Refugio == false && Fogata == true)
                {
                    Console.WriteLine("Posees una fogata");
                }
                Console.WriteLine("----------------------------");
                Console.WriteLine("> Buscar comida");
                Console.WriteLine("> Explorar la isla");
                Console.WriteLine("> Construir refugio");
                Console.WriteLine("> Encender fogata");
                Console.WriteLine("> Cocinar comida cruda");
                Console.WriteLine("> Comer comida");
                Console.WriteLine("> Descansar");
                Console.WriteLine("> Salir");
                Console.WriteLine();
                Console.Write("> ");
                Accion = Console.ReadLine();
                switch (Accion.ToLower())
                {
                    case "buscar comida":
                        int Rand_o = NumR.Next(1, 100);
                        
                        break;
                    case "explorar la isla":
                        break;
                    case "construir refugio":
                        break;
                    case "encender fogata":
                        break;
                    case "cocinar comida cruda":
                        break;
                    case "comer comida":
                        break;
                    case "descansar":
                        break;
                    case "salir":
                        {
                            string confirmacion = "";
                            while (confirmacion.ToLower() != "no")
                            {
                                confirmacion = "";
                                Console.Write("> Seguro? ");
                                confirmacion = Console.ReadLine();
                                switch (confirmacion.ToLower())
                                {
                                    case "si":
                                        return;
                                    default:
                                        Console.CursorTop--;
                                        Console.Write(new string(' ', Console.WindowWidth));
                                        Console.CursorTop--;
                                        break;
                                }
                            }
                            Console.Clear();
                            break;
                        }

                }
            }
        }
    }
}