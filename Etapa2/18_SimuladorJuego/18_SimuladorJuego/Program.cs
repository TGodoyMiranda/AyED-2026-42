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
            bool FinPartida = false; int Madera = 0;
            string Accion = "";
            while (FinPartida != true)
            {
                if (Vida <= 0)
                {
                    Console.WriteLine("> Perdiste!");
                    Console.ReadKey();
                    return;
                }
                Random NumR = new Random();
                int Num = NumR.Next(1, 101);
                Console.WriteLine("----------------------------");
                Console.WriteLine("  SUPERVIVENCIA EN LA ISLA");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Dias sobrevividos: " + Dias);
                Console.WriteLine("Vida: " + Vida + "  Hambre: " + Hambre);
                Console.WriteLine("Comida Cruda: " + Comida_Cruda + "  Madera: " + Madera);
                Console.WriteLine("Comida: " + Comida_Cocida);
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
                    default:
                        Console.Clear();
                        break;
                    case "buscar comida":
                        if (Num >= 50)
                        {
                            Console.WriteLine("> Encontraste comida! (+2 Comida cruda)");
                            Comida_Cruda += 2;
                        }
                        else
                        {
                            Console.WriteLine("> No encontraste nada.");
                        }
                        Console.ReadKey();
                        Vida -= 1;
                        Console.Clear();
                        break;
                    case "explorar la isla":
                        if (Num >= 50)
                        {
                                Console.WriteLine("> encontraste madera.");
                                Madera += 1;
                        }
                        else if (Num <= 49 && Num >= 21)
                        {
                            Console.WriteLine("> No encontraste nada.");
                        }
                        else
                        {
                            Console.WriteLine("> Sufriste un accidente (-2 vida)");
                            Vida -= 2;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "construir refugio":
                        if (Madera == 0)
                        {
                            Console.WriteLine("> Te quedaste pensando todo el dia en hacer tu refugio");
                            Console.WriteLine("> aunque no tenias el material necesario.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (Madera > 0)
                        {
                            Console.WriteLine("> Construiste un refugio");
                            Refugio = true;
                            Madera -= 1;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "encender fogata":
                        if (Madera == 0)
                        {
                            Console.CursorTop--;
                            Console.Write(new string(' ', Console.WindowWidth));
                            Console.CursorTop--;
                            Console.Clear();
                            Hambre += 2;
                            Dias += 1;
                        }
                        else if (Madera > 0)
                        {
                            Console.WriteLine("> Hiciste una fogata");
                            Fogata = true;
                            Madera -= 1;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case "cocinar comida cruda":
                        if (Fogata == false && Comida_Cruda == 0)
                        {
                            Console.WriteLine("> Te quedaste pensando en olor de la comida que cocinarias");
                            Console.WriteLine("> pero no cocinaste nada..");
                        }
                        else if (Comida_Cruda > 0)
                        {
                            Console.WriteLine("> Cocinaste comida");
                            Comida_Cruda -= 1;
                            Comida_Cocida += 1;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "comer comida":
                        if (Comida_Cruda == 0 && Comida_Cocida == 0)
                        {
                            Console.WriteLine("> Comiste aire");
                            Console.ReadKey();
                        }
                        else if (Comida_Cruda > 1 && Comida_Cocida == 0)
                        {
                            Console.WriteLine("> Comiste comida cruda, Baboso");
                            Comida_Cruda -= 1;
                            Hambre += 1;
                            Vida -= 1;
                        }
                        else if (Comida_Cocida > 0)
                        {
                            Console.WriteLine("> Comiste comida");
                            Comida_Cocida -= 1;
                            Hambre += 4;
                        }

                        if (Hambre > 10)
                        {
                            Hambre = 10;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "descansar":
                        if (Refugio == true && Fogata == true)
                        {
                            Console.WriteLine("> Dormiste excelente");
                            Vida += 8;
                        }
                        else if (Refugio == true || Fogata == true)
                        {
                            Console.WriteLine("> Dormiste bien");
                            Vida += 4;
                        }
                        else
                        {
                            Console.WriteLine("> Dormiste");
                            Vida += 1;
                        }

                        if (Vida > 10)
                        {
                            Vida = 10;
                        }
                        Console.ReadKey();
                        Console.Clear();
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
                if (Hambre > 0)
                {
                    Hambre -= 2;
                }
                else
                {
                    Vida -= 2;
                }
                Dias += 1;
                
            }
        }
    }
}