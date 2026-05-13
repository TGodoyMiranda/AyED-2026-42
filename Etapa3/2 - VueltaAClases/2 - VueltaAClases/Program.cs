using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡BIENVENIDO AL PROMEDIOMETRO!");
            Console.Write("Porfavor, Ingrese la cantidad de TPs que realizo: ");
            int CantTPs = int.Parse(Console.ReadLine());
            int[] TPs = new int[CantTPs];
            Console.Write("Porfavor, Ingrese la cantidad de Examenes que realizo: ");
            int CantExamenes = int.Parse(Console.ReadLine());
            int[] Examenes = new int[CantExamenes];
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < TPs.Length;)
            {
                Console.Write("Ingrese su nota en el TP N° " + (i + 1) + ": ");
                int NotaTP = int.Parse(Console.ReadLine());
                if (NotaTP <= 10 && NotaTP >= 0)
                {
                    TPs[i] = NotaTP;
                    i++;
                }
                else
                {
                    Console.WriteLine("Valor no Valido! Ingrese valores entre CERO y DIEZ, porfavor.");
                }
            }
            bool tpAprobado = false;
            if (1.0f * TPs.Sum() * 0.75f >= 6)
            {
                tpAprobado = true;
            }
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < Examenes.Length;)
            {
                Console.Write("Ingrese su nota en el examen N° " + (i + 1) + ": ");
                int NotaExamen = int.Parse(Console.ReadLine());
                if (NotaExamen <= 10 && NotaExamen >= 0)
                {
                    Examenes[i] = NotaExamen;
                    i++;
                }
                else
                {
                    Console.WriteLine("Valor no Valido! Ingrese valores entre CERO y DIEZ, porfavor.");
                }
            }
            Console.WriteLine("-----------------------------------------");
            bool examenAprobado = false;
            if (1.0f * Examenes.Sum() >= 6)
            {
                examenAprobado = true;
            }

            if (tpAprobado == true && examenAprobado == true)
            {
                Console.WriteLine("Aprobaras tu materia!");
            }
            else
            {
                Console.WriteLine("No aprobaras...");
            }
            Console.ReadKey();
        }
    }
}
