using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_HastaQueSI
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "";
            string rtacorrecta = "SI";
            while (respuesta != rtacorrecta )
            {
                Console.Write("Desea terminar el programa? ");
                respuesta = Console.ReadLine();
            }
            Console.WriteLine("Programa terminado, presione cualquier tecla para cerrar la ventana");
            Console.ReadKey();
        }
    }
}
