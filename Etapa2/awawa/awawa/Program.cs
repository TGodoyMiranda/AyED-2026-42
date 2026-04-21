using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awawa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meta numero: ");
            int Menu = int.Parse(Console.ReadLine());
                switch(Menu)
            {
                case 1:
                    Console.WriteLine("uno");
                    break;
                case 2:
                    Console.WriteLine("do");
                    break;
                case 3:
                    Console.WriteLine("TRI");
                    break;
            }
            Console.ReadKey();
        }
    }
}
