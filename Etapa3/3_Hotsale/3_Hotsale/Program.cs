using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Hotsale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Porfavor, Ingrese la cantidad de productos: ");
            int cantproductos = int.Parse(Console.ReadLine());
            int[] productos = new int[cantproductos];
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < productos.Length;)
            {
                Console.Write("Ingrese el precio del producto N° " + (i + 1) + ": ");
                int Precio = int.Parse(Console.ReadLine());
                productos[i] = Precio;
                i++;
            }
            Array.Sort(productos);
            int masAlto = productos.Max();
            int masBajo = productos.Min();
            Console.WriteLine("El precio más alto registrado fue " + masAlto + " y el más bajo fue " + masBajo + ".");
            Console.ReadKey();
        }
    }
}
