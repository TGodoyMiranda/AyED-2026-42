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
            int P_Jugador = 0; int P_Crupier = 0;
            string opcion = ""; bool Planto = false;
            Random Nram = new Random();
            while (true) 
            {
                Nram.Next(1, 101);
                Console.WriteLine("===== BLACKJACK =====");
                Console.WriteLine();
                Console.WriteLine("Puntaje Jugador:" + P_Jugador);
                Console.WriteLine("Puntaje Crupier: Oculto");
                Console.WriteLine();
                Console.WriteLine("1. Pedir carta");
                Console.WriteLine("2. Plantarse");
                Console.WriteLine("3. Ver reglas");
                Console.WriteLine("4. Salir");
                Console.WriteLine();
                Console.WriteLine("Escriba que hacer");
                opcion = Console.ReadLine();
                switch (opcion.ToLower())
                {
                    case "pedir carta":
                        break;
                    case "plantarse":
                        break;
                    case "ver reglas":
                        Console.Clear();
                        Console.WriteLine("⌌-----------------------------------------------------------------------------------------");
                        Console.WriteLine("│                         <==--- REGLAS ---==>");
                        Console.WriteLine("│· El jugador compite contra la computadora, que actúa como crupier.");
                        Console.WriteLine("│· El objetivo es acercarse lo más posible a 21 puntos sin pasarse.");
                        Console.WriteLine("│· Cada carta suma puntos al puntaje total del jugador o del crupier.");
                        Console.WriteLine("│· Si el jugador supera los 21 puntos, pierde la partida automáticamente.");
                        Console.WriteLine("│· Si el jugador decide plantarse, deja de pedir cartas y comienza el turno del crupier.");
                        Console.WriteLine("│· El crupier debe pedir cartas automáticamente mientras tenga menos de 17 puntos.");
                        Console.WriteLine("│· Cuando el crupier llega a 17 puntos o más, se planta.");
                        Console.WriteLine("│· Si el crupier supera los 21 puntos, gana el jugador.");
                        Console.WriteLine("│· Si ninguno se pasa de 21, gana quien tenga el puntaje más alto.");
                        Console.WriteLine("│· Si ambos terminan con el mismo puntaje, la partida queda empatada.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "salir":
                        break;

                }
            }
        }
    }
}
