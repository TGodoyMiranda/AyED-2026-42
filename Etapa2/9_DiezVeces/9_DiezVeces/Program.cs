using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_DiezVeces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una Palabra aqui: ");
            string pal = Console.ReadLine(); 
            int num = 0;
            while(num < 10)
            {
                num += 1;
                Console.WriteLine(pal);
            }
            Console.ReadKey();
        }
    }
}
