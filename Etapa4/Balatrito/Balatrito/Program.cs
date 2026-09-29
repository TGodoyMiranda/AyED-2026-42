using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balatrito
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== MINI BALATRO ===");
            Console.WriteLine();
            // Generar una mano aleatoria de 5 cartas
            string[] mano = GenerarmanoAleatoria();
            // Analizar que tipo de mano se obtuvo
            string tipo = TipoDemano(mano);
            // Calcular el valor de las cartas
            int basePts = PuntajeBase(mano);
            // Obtener el multiplicador de la jugada
            double mult = Multiplicador(tipo);
            // Calcular puntaje antes de Jokers
            double total = basePts * mult;
            // Jokers disponibles
            bool jokerX2 = true;
            bool jokerMas10 = true;
            // Aplicar los efectos de los Jokers 
            total = AplicarJokers(total, jokerX2, jokerMas10);
            // Mostrar el resultado
            string[] manotipobasePtsmulttotal = new string[Global.Elementos.Length];
            Array.Copy(Global.Elementos, manotipobasePtsmulttotal, Global.Elementos.Length);
            MostrarResumen(manotipobasePtsmulttotal);
        }
        // ====================================================
        // CREAR TODAS LAS FUNCIONES NECESARIAS DEBAJO DEL MAIN
        // ====================================================

        static string[] GenerarmanoAleatoria()
        {
            string[] mano = new string[5];
            Random rnd = new Random();
            if (Global.Elementos == null || Global.Elementos.Length < 6)
            {
                Global.Elementos = new string[6];
            }

            string Rangos = "AKQJT98765432";
            string Palos = "HDCS";

            for (int i = 0; i < 5; i++)
            {
                char rangoAleatorio = Rangos[rnd.Next(Rangos.Length)];
                char paloAleatorio = Palos[rnd.Next(Palos.Length)];
                mano[i] = $"{rangoAleatorio}{paloAleatorio}";
                Global.Elementos[i] = mano[i];
            }

            return mano;
        }

        static string TipoDemano(string[] mano)
        {
            var grupos = mano.GroupBy(carta => carta[0]).Select(g => g.Count()).ToList();

            if (grupos.Contains(3) && grupos.Contains(2))
            {
                Global.Elementos[5] = "Full";
                return "Full";
            }
            if (grupos.Contains(4)) { Global.Elementos[5] = "Poker"; return "Poker"; } ;
            if (grupos.Contains(3)) { Global.Elementos[5] = "Trio"; return "Trio"; };
            if (grupos.Contains(2)) { Global.Elementos[5] = "Par"; return "Par"; }
            else { Global.Elementos[5] = "Nada"; return "Nada"; };
        }
        static int PuntajeBase(string[] mano)
        {
            string RangoNoNumerico = "AKQJT";
            int Puntaje = 0;
            for (int i = 0; i < mano.GetLength(0); i++)
            {
                if (mano[i][0] == RangoNoNumerico[0]) { Puntaje = Puntaje + 14; }
                else if (mano[i][0] == RangoNoNumerico[1]) { Puntaje = Puntaje + 13; }
                else if (mano[i][0] == RangoNoNumerico[2]) { Puntaje = Puntaje + 12; }
                else if (mano[i][0] == RangoNoNumerico[3]) { Puntaje = Puntaje + 11; }
                else if (mano[i][0] == RangoNoNumerico[4]) { Puntaje = Puntaje + 10; }
                else { Puntaje = Puntaje + mano[i][0]; }
            }
            Global.Elementos[6] = Puntaje.ToString();
            return Puntaje;
        }
        static double Multiplicador(string tipo)
        {
            double Mult = 1.0;
            if (tipo == "Par") { Mult = 1.5; }
            else if (tipo == "Trio") { Mult = 2.5; }
            else if (tipo == "Full") { Mult = 3.5; }
            else if (tipo == "Poker") { Mult = 4.0; }
            Global.Elementos[7] = tipo;
            return Mult;
        }
        static double AplicarJokers(double total, bool jokerX2, bool jokerMas10)
        {
            if (jokerX2 == true) { total = total * 2; }
            if (jokerMas10 == true) { total = total + 10; }
            Global.Elementos[7] = total.ToString();
            return total;
        }
        static void MostrarResumen(string[] manotipobasePtsmulttotal)
        {
            for (int i = 0; i < 8; i++)
            {
                if (i < 5)
                {
                    Console.Write(" " + Global.Elementos[i]);
                }
                if (i == 4) { Console.WriteLine("\n-----------------------------"); }
                if (i == 5) { Console.WriteLine("Tipo de mano: " + Global.Elementos[5]); }
                if (i == 6) { Console.WriteLine("Multiplicador: " + Global.Elementos[6]); }
                if (i == 7) { Console.WriteLine("Total: " + Global.Elementos[7]); }
            }
            Console.ReadKey();
        }
        public static class Global
        {
            public static string[] Elementos { get; set; } = new string[8];
        }
    }
}
