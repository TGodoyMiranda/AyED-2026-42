using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Calculando
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora(1, 2);
        }
        static void Calculadora(int Valor1, int Valor2)
        {
            while (true)
            {
                Console.Write("Introduce la operación: ");
                string Operacion = Console.ReadLine(); 
                switch (Operacion.ToLower())
                {
                    case "sumar":
                        Sumar(Valor1, Valor2);
                        return;
                    case "restar":
                        Restar(Valor1, Valor2);
                        return;
                    case "multiplicar":
                        Multiplicar(Valor1, Valor2);
                        return;
                    case "dividir":
                        Dividir(Valor1, Valor2);
                        return;
                    default:
                        Console.Clear();
                        break;
                }
                
            }
        }
        static void Sumar(int Valor1, int Valor2)
        {
            int Valorfinal = Valor1 + Valor2;
            Console.WriteLine(Valorfinal);
            Console.ReadKey();
        }
        static void Restar(int Valor1, int Valor2)
        {
            int Valorfinal = Valor1 - Valor2;
            Console.WriteLine(Valorfinal);
            Console.ReadKey();
        }
        static void Multiplicar(int Valor1, int Valor2)
        {
            int Valorfinal = Valor1 * Valor2;
            Console.WriteLine(Valorfinal);
            Console.ReadKey();
        }
        static void Dividir(int Valor1, int Valor2)
        {
            int Valorfinal = Valor1 / Valor2;
            Console.WriteLine(Valorfinal);
            Console.ReadKey();
        }
    }
}
