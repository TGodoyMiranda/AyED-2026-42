<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de invitados: ");
            int Ninvitados = int.Parse(Console.ReadLine());
            int[] Invitados = new int[Ninvitados];
            for(int i = 0; i < Invitados.Length;)
            {
                Console.Write("Ingrese la cantidad de comida que el invitado (Entre 1 y 100) " + (i + 1) + " consumira: ");
                int CantCom = int.Parse(Console.ReadLine());
                if (CantCom <= 100 && CantCom >= 1)
                {
                    Invitados[i] = CantCom;
                    i++;
                }
                else
                {
                    Console.WriteLine("Valor no valido (Debe ser entre 1 y 100)");
                }
            }
            float Porcentaje = (1.0f * Invitados.Sum()) / (1.0f * Ninvitados);
            Console.WriteLine("Deberas darle " + Porcentaje + " en promedio a cada invitado.");
            Console.ReadKey();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de invitados: ");
            int Ninvitados = int.Parse(Console.ReadLine());
            int[] Invitados = new int[Ninvitados];
            for(int i = 0; i > Invitados.Length; i++)
            {
                Console.Write("Ingrese la cantidad de comida que el invitado" + (i + 1) + "consumira.");
                int cantcom = int.Parse(Console.ReadLine());
            }
            foreach(int i in Invitados)
            {
                Porcentaje
            }
        }
    }
}
>>>>>>> 5b2b7643e0b8ae66be55efc1effd96b35f11b754
