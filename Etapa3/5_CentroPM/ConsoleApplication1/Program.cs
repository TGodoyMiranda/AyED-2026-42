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
            
            string Accion = "";
            int[] pokemones = new int[0];
            while (true)
            {
                Random NumR = new Random();
                Console.WriteLine("----------------------------");
                Console.WriteLine("       CENTRO POKEMON");
                Console.WriteLine("----------------------------");
                Console.WriteLine("> 1. Registrar un nuevo pokémon");
                Console.WriteLine("> 2. Mostrar la vida de todos los pokemones");
                Console.WriteLine("> 3. Curar un pokémon");
                Console.WriteLine("> 4. Dañar un pokémon");
                Console.WriteLine("> 5. Curar a todos los pokemones");
                Console.WriteLine("> 6. Simular ataque enemigo a todo el equipo");
                Console.WriteLine("> 7. Mostrar el pokemon con mayor vida");
                Console.WriteLine("> 8. Mostrar el pokemon con menor vida");
                Console.WriteLine("> 9. Calcular promedio de vida del equipo");
                Console.WriteLine("> 10. Ordenar pokemones por vida de menor a mayor");
                Console.WriteLine("> 11. Ordenar pokemones por vida de mayor a menor");
                Console.WriteLine("> 12. Mostrar pokemones debilitados");
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
                        if (pokemones.Length + cantpokemones > 6)
                        {
                            Console.CursorTop--;
                            Console.Write(new string(' ', Console.WindowWidth));
                            Console.CursorTop--;
                            Console.WriteLine("No puedes tener más de 6 pokemones en total. Actualmente tienes: " + pokemones.Length);
                        }
                        else
                        {
                            int posicionInicial = pokemones.Length;
                            Array.Resize(ref pokemones, pokemones.Length + cantpokemones);
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("Nota: Solo valores de 0 a 100 incluyentes seran considerados validos");
                            Console.WriteLine("");

                            for (int i = 0; i < cantpokemones;)
                            {
                                Console.Write("Ingrese la vida del pokémon N° " + (posicionInicial + i + 1) + ": ");
                                int NumPoke = int.Parse(Console.ReadLine());

                                if (NumPoke >= 0 && NumPoke <= 100)
                                {
                                    pokemones[posicionInicial + i] = NumPoke;
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

                        if (pokemones.Length > 1)
                        {
                            Console.WriteLine("Puntos de vida y estado de tu equipo");
                            Console.WriteLine("");
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
                        else if (pokemones.Length == 1)
                        {
                            Console.Write("Tu pokemon tiene" + pokemones[0] + "de vida");
                            if (pokemones[0] == 0)
                            {
                                Console.WriteLine("(Debilitado)");
                            }
                            else if (pokemones[0] >= 1 && pokemones[0] <= 30)
                            {
                                Console.WriteLine("(Estado critico)");
                            }
                            else if (pokemones[0] >= 31 && pokemones[0] <= 70)
                            {
                                Console.WriteLine("(Herido)");
                            }
                            else if (pokemones[0] >= 71 && pokemones[0] <= 100)
                            {
                                Console.WriteLine("(Buen estado)");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No tienes ningun pokemon!");
                            Console.WriteLine("Registra tus pokemones");
                            Console.WriteLine("escribiendo '1' en la pantalla incial.");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        if (pokemones.Length > 1)
                        {
                            Console.Write("Que pokémon curar? ");
                            int N_PKMN = int.Parse(Console.ReadLine());
                            int indice = N_PKMN - 1;
                            Console.Write("Por cuanto curar? ");
                            int CantCura = int.Parse(Console.ReadLine());
                            pokemones[indice] = pokemones[indice] + CantCura;
                            Console.WriteLine("El pokemon N° " + N_PKMN + " ha sido curado");
                            Console.WriteLine("Vida actual: " + pokemones[indice]);
                        }
                        else if (pokemones.Length == 1)
                        {
                            Console.Write("Por cuanto curar tu pokemon? ");
                            int CantCura = int.Parse(Console.ReadLine());
                            pokemones[0] = pokemones[0] + CantCura;
                            Console.WriteLine("Tu pokemon ha sido curado");
                            Console.WriteLine("Vida actual: " + pokemones[0]);
                        }
                        else
                        {
                            Console.WriteLine("No tienes ningun pokemon!");
                            Console.WriteLine("Registra tus pokemones");
                            Console.WriteLine("escribiendo '1' en la pantalla incial.");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        {
                            if (pokemones.Length > 1)
                            {
                                Console.Write("Que pokémon dañar? ");
                                int N_PKMN = int.Parse(Console.ReadLine());
                                int indice = N_PKMN - 1;
                                Console.Write("Por cuanto dañar? ");
                                int Cantdaño = int.Parse(Console.ReadLine());
                                pokemones[indice] = pokemones[indice] - Cantdaño;
                                Console.WriteLine("El pokemon N° " + N_PKMN + " ha sido dañado");
                                Console.WriteLine("Vida actual: " + pokemones[indice]);
                            }
                            else if (pokemones.Length == 1)
                            {
                                Console.Write("Por cuanto dañar tu pokemon? ");
                                int Cantdaño = int.Parse(Console.ReadLine());
                                pokemones[0] = pokemones[0] - Cantdaño;
                                Console.WriteLine("Tu pokemon ha sido dañado");
                                Console.WriteLine("Vida actual: " + pokemones[0]);
                            }
                            else
                            {
                                Console.WriteLine("No tienes ningun pokemon!");
                                Console.WriteLine("Registra tus pokemones");
                                Console.WriteLine("escribiendo '1' en la pantalla incial.");
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "5":
                        {
                            if (pokemones.Length > 1)
                            {
                                Console.Write("Por cuanto curar a todo tu equipo? ");
                                int CantCura = int.Parse(Console.ReadLine());
                                foreach (int i in pokemones)
                                {
                                    pokemones[i] = pokemones[i] + CantCura;
                                }
                                Console.WriteLine("Tus pokemones fueron curados");
                            }
                            else if (pokemones.Length == 1)
                            {
                                Console.Write("Por cuanto curar tu pokemon? ");
                                int CantCura = int.Parse(Console.ReadLine());
                                pokemones[0] = pokemones[0] + CantCura;
                                Console.WriteLine("Tu pokemon ha sido curado");
                                Console.WriteLine("Vida actual: " + pokemones[0]);
                            }
                            else
                            {
                                Console.WriteLine("No tienes ningun pokemon!");
                                Console.WriteLine("Registra tus pokemones");
                                Console.WriteLine("escribiendo '1' en la pantalla incial.");
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "6":
                        {
                            int Num = NumR.Next(5, 25);
                            if (pokemones.Length > 1)
                            {
                                Console.WriteLine("¡Un pokémon salvaje atacó al equipo!");
                                Console.WriteLine("Daño recibido por todos: " + Num);
                                Console.WriteLine("");
                                Console.WriteLine("Las vidas fueron actualizadas.");
                            }
                            else if (pokemones.Length == 1)
                            {
                                Console.WriteLine("¡Un pokémon salvaje atacó a tu pokemon!");
                                Console.WriteLine("Daño recibido por tu Pokemon: " + Num);
                                Console.WriteLine("");
                                Console.WriteLine("Su vida fue actualizada.");
                            }
                            else
                            {
                                Console.WriteLine("No tienes ningun pokemon!");
                                Console.WriteLine("Registra tus pokemones");
                                Console.WriteLine("escribiendo '1' en la pantalla incial.");
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "7":
                        {
                            if (pokemones.Length > 0)
                            {
                                int maxVida = pokemones[0];
                                int posicionMax = 0;
                                for (int i = 1; i < pokemones.Length; i++)
                                {
                                    if (pokemones[i] > maxVida)
                                    {
                                        maxVida = pokemones[i];
                                        posicionMax = i;
                                    }
                                }
                                Console.WriteLine("Tu pokemon con mas vida esta en la posicion: " + posicionMax);
                                Console.WriteLine("Vida: " + maxVida);
                            }
                            else
                            {
                                Console.WriteLine("No tienes ningun pokemon!");
                                Console.WriteLine("Registra tus pokemones");
                                Console.WriteLine("escribiendo '1' en la pantalla incial.");
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "8":
                        {
                            if (pokemones.Length > 0)
                            {
                                int minVida = pokemones[0];
                                int posicionMin = 0;
                                for (int i = 1; i < pokemones.Length; i++)
                                {
                                    if (pokemones[i] < minVida)
                                    {
                                        minVida = pokemones[i];
                                        posicionMin = i;
                                    }
                                }
                                Console.WriteLine("Tu pokemon con mas vida esta en la posicion: " + posicionMin);
                                Console.WriteLine("Vida: " + minVida);
                            }
                            else
                            {
                                Console.WriteLine("No tienes ningun pokemon!");
                                Console.WriteLine("Registra tus pokemones");
                                Console.WriteLine("escribiendo '1' en la pantalla incial.");
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "9":
                        int PromVida = pokemones.Sum() / pokemones.Length;
                        if (PromVida )
                        break;
                    case "12":
                        {
                            if (pokemones.Length >= 2)
                            {
                                Console.WriteLine("Pokemones Debilitados");
                                int l = 0;
                                bool debilitado = false;
                                foreach (int i in pokemones)
                                {
                                    l++;
                                    if (pokemones[i] == 0)
                                    {
                                        Console.WriteLine("Pokémon N° " + l + " esta debilitado");
                                        debilitado = true;
                                    }
                                }
                                if (debilitado == false)
                                {
                                    Console.WriteLine("No tienes ningun pokemon de tu grupo esta debilitado, Hurrah!");
                                }
                            }
                          else if (pokemones.Length == 1)
                            {
                               if (pokemones[0] > 0)
                                {
                                    Console.WriteLine("Tu pokemon no esta debilitado.");
                                }
                               else
                                {
                                    Console.WriteLine("Tu pokemon esta debilitado.");
                                }
                            }
                         else
                            {
                                Console.WriteLine("No tienes ningun pokemon!");
                                Console.WriteLine("Registra tus pokemones");
                                Console.WriteLine("escribiendo '1' en la pantalla incial.");
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
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
