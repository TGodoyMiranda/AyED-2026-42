using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Apocalipsis
{
    class Program
    {
        static void Main(string[] args)
        {
            int Puntos = 0;
            string Con1 = "";
            Console.Write("Tiene un bate? ");
            Con1 = Console.ReadLine();
            if (Con1.ToLower() == "si")
            {
                Puntos += 1;
                Con1 = "";
            }
            else if (Con1.ToLower() == "no")
            {
                Puntos -= 1;
                Con1 = "";
            }
            Console.Write("Tiene un refugio? ");
            Con1 = Console.ReadLine();
            if (Con1.ToLower() == "si")
            {
                Puntos += 1;
                Con1 = "";
            }
            else if (Con1.ToLower() == "no")
            {
                Puntos -= 1;
                Con1 = "";
            }
            Console.Write("Tiene agua? ");
            Con1 = Console.ReadLine();
            if (Con1.ToLower() == "si")
            {
                Puntos += 1;
                Con1 = "";
            }
            else if (Con1.ToLower() == "no")
            {
                Puntos -= 1;
                Con1 = "";
            }
            Console.Write("Tiene comida? ");
            Con1 = Console.ReadLine();
            if (Con1.ToLower() == "si")
            {
                Puntos += 1;
                Con1 = "";
            }
            else if (Con1.ToLower() == "no")
            {
                Puntos -= 1;
                Con1 = "";
            }
            Console.Write("Tiene comida? ");
            Con1 = Console.ReadLine();
            if (Con1.ToLower() == "si")
            {
                Puntos += 1;
                Con1 = "";
            }
            else if (Con1.ToLower() == "no")
            {
                Puntos -= 1;
                Con1 = "";
            }
            Console.Write("Tiene botiquin? ");
            Con1 = Console.ReadLine();
            if (Con1.ToLower() == "si")
            {
                Puntos += 1;
                Con1 = "";
            }
            else if (Con1.ToLower() == "no")
            {
                Puntos -= 1;
                Con1 = "";
            }

            if (Puntos >= 3)
            {
                Console.WriteLine("Sobrevivis el apocalipsis.");
            }
            else
            {
                Console.WriteLine("No sobrevivis el apocalipsis.");
            }
            Console.ReadKey();
        }
    }
}
