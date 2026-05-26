using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Vida = 10; int Hambre = 10; int Dias = 1;
            int Comida_Cruda = 0; int Comida_Cocida = 0;
            bool Refugio = false; bool Fogata = false;
            bool FinPartida = false; int Madera = 0;
            string Accion = "";
            int[] pokemones = new int[0];
            while (FinPartida != true)
            {
                Random NumR = new Random();
                int Num = NumR.Next(1, 101);
                Console.WriteLine("----------------------------");
                Console.WriteLine("       CENTRO POKEMON");
                Console.WriteLine("----------------------------");
                Console.WriteLine("> 1. Registrar un nuevo pokémon");
                Console.WriteLine("> 2. Mostrar la vida de todos los pokemones");
                Console.WriteLine("> 3. Curar un pokémon");
                Console.WriteLine("> 4. Dañar un pokémon");
                Console.WriteLine("> 5. Curar a todos los pokemones");
                Console.WriteLine("> 6. Mostrar pokemones debilitados");
                Console.WriteLine("> 7. Mostrar el pokemon con mayor vida");
                Console.WriteLine("> 8. Mostrar el pokemon con menor vida");
                Console.WriteLine("> 9. Calcular promedio de vida del equipo");
                Console.WriteLine("> 10. Ordenar pokemones por vida de menor a mayor");
                Console.WriteLine("> 11. Ordenar pokemones por vida de mayor a menor");
                Console.WriteLine("> 12. Simular ataque enemigo a todo el equipo");
                Console.WriteLine("> 13. Salir");

                Console.WriteLine();
                Console.WriteLine("Que haras? (Responder con numero)");
                Accion = Console.ReadLine();
                switch (Accion.ToLower())

                {
                    default:
                        Console.Clear();
                        break;
                    case "1":
                        Console.Write("Porfavor, Ingrese la cantidad de pokemones: ");
                        int cantpokemones = int.Parse(Console.ReadLine());
                        if (cantpokemones >= 6)
                        {
                            Console.CursorTop--;
                            Console.Write(new string(' ', Console.WindowWidth));
                            Console.CursorTop--;
                            Console.WriteLine("No puedes añadir mas que 6 pokemones");
                        }
                        else
                        {
                            Array.Resize(ref pokemones, pokemones.Length + cantpokemones);
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("Nota: Solo valores de 0 a 100 incluyentes seran considerados validos");
                            Console.WriteLine("");
                            for (int i = 0; i < cantpokemones;)
                            {
                                Console.Write("Ingrese la vida del pokémon N° " + (i + 1) + ": ");
                                int NumPoke = int.Parse(Console.ReadLine());
                                if (NumPoke >= 0 && NumPoke <= 100)
                                {
                                    pokemones[i] = NumPoke;
                                    i++;
                                }
                                else
                                {
                                    Console.CursorTop--;
                                    Console.Write(new string(' ', Console.WindowWidth));
                                    Console.CursorTop--;
                                }
                            }
                            Console.WriteLine("Has añadido " + cantpokemones + " pokemones correctamente");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine(pokemones.Length);
                        if (pokemones.Length > 0)
                        {
                            int l = 0;
                            foreach (int i in pokemones)
                            {
                                l += 1;
                                Console.Write("Pokémon N° " + l + " - " + i + " puntos de vida. ");
                                if (i == 0)
                                {
                                    Console.WriteLine("(Debilitado)");
                                }
                                else if (i >= 1 && i <= 30)
                                {
                                    Console.WriteLine("(Estado critico)");
                                }
                                else if (i >= 31 && i <= 70)
                                {
                                    Console.WriteLine("(Herido)");
                                }
                                else if (i >= 71 && i <= 100)
                                {
                                    Console.WriteLine("(Buen estado)");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Necesitas al menos un Pokemon para mostrar sus valores de vida!");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        if (pokemones.Length > 0)
                        {
                            Console.Write("Que pokémon curar? ");
                            int N_PKMN = int.Parse(Console.ReadLine());
                            int indice = N_PKMN - 1;
                            Console.Write("Por cuanto curar? ");
                            int CantCura = int.Parse(Console.ReadLine());
                            pokemones[indice] = pokemones[indice] + CantCura;
                            Console.WriteLine("El pokemon N° " + N_PKMN + " ha sido curado.");
                            Console.WriteLine("Vida actual: " + pokemones[indice]);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("No ingresaste ningun pokemon para curar!");
                        }
                        break;
                    case "4":
                        {
                            if (pokemones.Length < 0)
                            {
                                Console.Write("Que pokémon dañar? ");
                                int N_PKMN = int.Parse(Console.ReadLine());
                                int indice = N_PKMN - 1;
                                Console.Write("Por cuanto dañar? ");
                                int CantDaño = int.Parse(Console.ReadLine());
                                pokemones[indice] = pokemones[indice] - CantDaño;
                                Console.Write("El pokemon N° " + N_PKMN + " ha sido dañado.");
                                Console.WriteLine("Vida actual: " + pokemones[indice]);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        }
                    case "5":
                        {
                            Console.Write("Por cuanto curar a todo tu equipo? ");
                            int CantCura = int.Parse(Console.ReadLine());
                            foreach (int i in pokemones)
                            {
                                pokemones[i] = pokemones[i] + CantCura;
                            }
                            Console.WriteLine("Tus pokemones fueron curados");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    case "7":
                        if (Refugio == true && Fogata == true)
                        {
                            Console.WriteLine("> Dormiste excelente");
                            Vida += 8;
                        }
                        else if (Refugio == true || Fogata == true)
                        {
                            Console.WriteLine("> Dormiste bien");
                            Vida += 4;
                        }
                        else
                        {
                            Console.WriteLine("> Dormiste");
                            Vida += 1;
                        }

                        if (Vida > 10)
                        {
                            Vida = 10;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "13":
                        {
                            string confirmacion = "";
                            while (confirmacion.ToLower() != "no")
                            {
                                confirmacion = "";
                                Console.Write("> Seguro? ");
                                confirmacion = Console.ReadLine();
                                switch (confirmacion.ToLower())
                                {
                                    case "si":
                                        return;
                                    default:
                                        Console.CursorTop--;
                                        Console.Write(new string(' ', Console.WindowWidth));
                                        Console.CursorTop--;
                                        break;
                                }
                            }
                            Console.Clear();
                            break;

                        }
                }
            }
        }
    }
}
