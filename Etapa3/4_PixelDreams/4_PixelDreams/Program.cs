using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Porfavor, Ingrese la cantidad de participantes: ");
            int cantparticipantes = int.Parse(Console.ReadLine());
            int[] participantes = new int[cantparticipantes];
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < participantes.Length;)
            {
                Console.Write("Ingrese el puntos del participante " + (i + 1) + ": ");
                int puntos = int.Parse(Console.ReadLine());
                participantes[i] = puntos;
                i++;
            }
            Array.Sort(participantes);
            Array.Reverse(participantes);
            int masAlto = participantes.Max();
            int masBajo = participantes.Min();
            foreach(int i in participantes)
            {
                if (i == participantes.Max())
                {
                    Console.WriteLine("Puesto N° " + i + " <------ Mayor Puntaje.");
                }
                else if (i == participantes.Min())
                {
                    Console.WriteLine("Puesto N° " + i + " <------ Menor Puntaje.");
                }
                else
                {
                    Console.WriteLine("Puesto N° " + i + ".");
                }
            }
            Console.ReadKey();
        }
        }
    }
