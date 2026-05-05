using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            int P_Jugador = 0; int P_Crupier = 0; int RG_Jugador = 0; int RG_Crupier = 0;
            string opcion = "";
            List<string> CartasCuprier = new List<string>();
            Random Nram = new Random();
            while (true) 
            {
                Console.WriteLine("===== BLACKJACK =====");
                Console.WriteLine();
                Console.WriteLine("Puntaje Jugador: " + P_Jugador + " Rondas ganadas: " + RG_Jugador);
                Console.WriteLine("Puntaje Crupier: " + P_Crupier + " Rondas ganadas: " + RG_Crupier);
                Console.WriteLine();
                Console.Write("Cartas del Crupier: "); CartasCuprier.ForEach(Console.Write);
                Console.WriteLine();
                Console.WriteLine("1. Pedir carta");
                Console.WriteLine("2. Plantarse");
                Console.WriteLine("3. Ver reglas");
                Console.WriteLine("4. Salir");
                Console.WriteLine();
                Console.WriteLine("Escriba que hacer (El numero al lado de la accion)");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    default:
                        Console.CursorTop--;
                        Console.Write(new string(' ', Console.WindowWidth));
                        Console.CursorTop--;
                        Console.Clear();
                        break;
                    case "1":
                        int N = Nram.Next(1, 12);
                        if (N == 11)
                        {
                            Console.Write("Obtuviste un as! Lo conviertes en 1 o 11? ");
                            string valorAs = Console.ReadLine();
                            switch (valorAs)
                            {
                                case "1":
                                    P_Jugador += 1;
                                    break;
                                case "11":
                                    P_Jugador += 11;
                                    break;
                            }
                        }
                        else
                        {
                            P_Jugador += N;
                        }

                        if (P_Jugador > 21)
                        {
                            Console.WriteLine("Perdiste!");
                            P_Jugador = 0;
                            P_Crupier = 0;
                            RG_Crupier += 1;
                            Console.ReadKey();
                        }
                        Console.Clear();
                        break;
                    case "2":
                        while (P_Crupier < 17)
                        {
                            int M = Nram.Next(1, 13);
                            int L = Nram.Next(1, 4);
                            if (M == 10)
                            {
                                if (L == 1)
                                {
                                    CartasCuprier.Add("J ");
                                    P_Crupier += 10;
                                }
                                else if (L == 2)
                                {
                                    CartasCuprier.Add("Q ");
                                    P_Crupier += 10;
                                }
                                else if (L == 3)
                                {
                                    CartasCuprier.Add("K ");
                                    P_Crupier += 10;
                                }
                            }
                            else
                            {
                                P_Crupier += M;
                                CartasCuprier.Add(M + " ");
                            }
                            Console.SetCursorPosition(20, 5); // Mueve a la primera línea
                            CartasCuprier.ForEach(Console.Write);
                            Console.SetCursorPosition(0, 13);
                            Console.WriteLine("Saco un " + M);
                            Console.ReadKey();
                        }
                        if (P_Crupier > 21 || P_Crupier < P_Jugador)
                        {
                            Console.WriteLine("Ganaste");
                            RG_Jugador += 1;
                            P_Jugador = 0;
                            P_Crupier = 0;
                        }
                        else if (P_Crupier > P_Jugador)
                        {
                            Console.WriteLine("Perdiste");
                            RG_Crupier += 1;
                            P_Jugador = 0;
                            P_Crupier = 0;
                        }
                        else if (P_Jugador == P_Crupier)
                        {
                            Console.WriteLine("Empataste");
                        }
                        CartasCuprier.Clear();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("                                    <==--- REGLAS ---==>");
                        Console.WriteLine("  > El jugador compite contra la computadora, que actúa como crupier.");
                        Console.WriteLine("  > El objetivo es acercarse lo más posible a 21 puntos sin pasarse.");
                        Console.WriteLine("  > Cada carta suma puntos al puntaje total del jugador o del crupier.");
                        Console.WriteLine("  > Si el jugador supera los 21 puntos, pierde la partida automáticamente.");
                        Console.WriteLine("  > Si el jugador decide plantarse, deja de pedir cartas y comienza el turno del crupier.");
                        Console.WriteLine("  > El crupier debe pedir cartas automáticamente mientras tenga menos de 17 puntos.");
                        Console.WriteLine("  > Cuando el crupier llega a 17 puntos o más, se planta.");
                        Console.WriteLine("  > Si el crupier supera los 21 puntos, gana el jugador.");
                        Console.WriteLine("  > Si ninguno se pasa de 21, gana quien tenga el puntaje más alto.");
                        Console.WriteLine("  > Si ambos terminan con el mismo puntaje, la partida queda empatada.");
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("  > Presione cualquier letra para salir");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
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
