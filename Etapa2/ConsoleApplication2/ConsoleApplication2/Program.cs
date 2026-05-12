using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] asd = {0,0,0};
            for (int i = 0; i<3; i++)
            {
                asd[i] = 3 + i;
                Console.WriteLine("{0}", asd[i]);
            }
            Console.ReadKey();
        }
    }
}
