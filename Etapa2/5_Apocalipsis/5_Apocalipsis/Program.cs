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
            Console.Write("Tiene un bate? ");
            string Batcon = Console.ReadLine();
            Console.Write("Tiene un refugio ");
            string Refcon = Console.ReadLine();
            Console.Write("Tiene comida? ");
            string Comcon = Console.ReadLine();
            Console.Write("Tiene agua? ");
            string Agucon = Console.ReadLine();
            Console.Write("Tiene botiquin? ");
            string Botcon = Console.ReadLine();
            if (Batcon.ToLower() == "si" && Refcon.ToLower() == "si" && Comcon.ToLower() == "si" && Agucon.ToLower() == "si" && Botcon.ToLower() == "si")
            {
                Console.WriteLine("Usted sobrevivira");
            }
            else if (Batcon.ToLower() == "si" && Refcon.ToLower() == "no" && Comcon.ToLower() == "si" && Agucon.ToLower() == "si" && Botcon.ToLower() == "no")
            {
                Console.WriteLine("Usted sobrevivira");
            }
            else if (Batcon.ToLower() == "no" && Refcon.ToLower() == "no" && Comcon.ToLower() == "no" && Agucon.ToLower() == "no" && Botcon.ToLower() == "no")
            {
                Console.WriteLine("Usted no sobrevivira");
            }


        }
    }
}
