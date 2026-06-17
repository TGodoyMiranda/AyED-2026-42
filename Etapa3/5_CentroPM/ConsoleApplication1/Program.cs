<<<<<<< HEAD
﻿using System;
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
            int[] vidasPokemones = new int[0];
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
                Console.WriteLine("> 13. Usar Pocion Maxima");
                Console.WriteLine("> 14. Salir");

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
                        if (vidasPokemones.Length + cantpokemones > 6)
                        {
                            Console.CursorTop--;
                            Console.Write(new string(' ', Console.WindowWidth));
                            Console.CursorTop--;
                            Console.WriteLine("No puedes tener más de 6 pokemones en total. Actualmente tienes: " + vidasPokemones.Length);
                        }
                        else
                        {
                            int posicionInicial = vidasPokemones.Length;
                            Array.Resize(ref vidasPokemones, vidasPokemones.Length + cantpokemones);
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("Nota: Solo valores de 0 a 100 incluyentes seran considerados validos");
                            Console.WriteLine("");

                            for (int i = 0; i < cantpokemones;)
                            {
                                Console.Write("Ingrese la vida del pokémon N° " + (posicionInicial + i + 1) + ": ");
                                int NumPoke = int.Parse(Console.ReadLine());

                                if (NumPoke >= 0 && NumPoke <= 100)
                                {
                                    vidasPokemones[posicionInicial + i] = NumPoke;
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

                        if (vidasPokemones.Length > 1)
                        {
                            Console.WriteLine("Puntos de vida y estado de tu equipo");
                            Console.WriteLine("");
                            int l = 0;
                            foreach (int i in vidasPokemones)
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
                        else if (vidasPokemones.Length == 1)
                        {
                            Console.Write("Tu pokemon tiene" + vidasPokemones[0] + "de vida");
                            if (vidasPokemones[0] == 0)
                            {
                                Console.WriteLine("(Debilitado)");
                            }
                            else if (vidasPokemones[0] >= 1 && vidasPokemones[0] <= 30)
                            {
                                Console.WriteLine("(Estado critico)");
                            }
                            else if (vidasPokemones[0] >= 31 && vidasPokemones[0] <= 70)
                            {
                                Console.WriteLine("(Herido)");
                            }
                            else if (vidasPokemones[0] >= 71 && vidasPokemones[0] <= 100)
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
                        if (vidasPokemones.Length > 1)
                        {
                            Console.Write("Que pokémon curar? ");
                            int N_PKMN = int.Parse(Console.ReadLine());
                            int indice = N_PKMN - 1;
                            Console.Write("Por cuanto curar? ");
                            int CantCura = int.Parse(Console.ReadLine());
                            vidasPokemones[indice] = vidasPokemones[indice] + CantCura;
                            Console.WriteLine("El pokemon N° " + N_PKMN + " ha sido curado");
                            Console.WriteLine("Vida actual: " + vidasPokemones[indice]);
                        }
                        else if (vidasPokemones.Length == 1)
                        {
                            Console.Write("Por cuanto curar tu pokemon? ");
                            int CantCura = int.Parse(Console.ReadLine());
                            vidasPokemones[0] = vidasPokemones[0] + CantCura;
                            Console.WriteLine("Tu pokemon ha sido curado");
                            Console.WriteLine("Vida actual: " + vidasPokemones[0]);
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
                            if (vidasPokemones.Length > 1)
                            {
                                Console.Write("Que pokémon dañar? ");
                                int N_PKMN = int.Parse(Console.ReadLine());
                                int indice = N_PKMN - 1;
                                Console.Write("Por cuanto dañar? ");
                                int Cantdaño = int.Parse(Console.ReadLine());
                                vidasPokemones[indice] = vidasPokemones[indice] - Cantdaño;
                                Console.WriteLine("El pokemon N° " + N_PKMN + " ha sido dañado");
                                Console.WriteLine("Vida actual: " + vidasPokemones[indice]);
                            }
                            else if (vidasPokemones.Length == 1)
                            {
                                Console.Write("Por cuanto dañar tu pokemon? ");
                                int Cantdaño = int.Parse(Console.ReadLine());
                                vidasPokemones[0] = vidasPokemones[0] - Cantdaño;
                                Console.WriteLine("Tu pokemon ha sido dañado");
                                Console.WriteLine("Vida actual: " + vidasPokemones[0]);
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
                            if (vidasPokemones.Length > 1)
                            {
                                Console.Write("Por cuanto curar a todo tu equipo? ");
                                int CantCura = int.Parse(Console.ReadLine());
                                foreach (int i in vidasPokemones)
                                {
                                    vidasPokemones[i] = vidasPokemones[i] + CantCura;
                                }
                                Console.WriteLine("Tus pokemones fueron curados");
                            }
                            else if (vidasPokemones.Length == 1)
                            {
                                Console.Write("Por cuanto curar tu pokemon? ");
                                int CantCura = int.Parse(Console.ReadLine());
                                vidasPokemones[0] = vidasPokemones[0] + CantCura;
                                Console.WriteLine("Tu pokemon ha sido curado");
                                Console.WriteLine("Vida actual: " + vidasPokemones[0]);
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
                            if (vidasPokemones.Length > 1)
                            {
                                Console.WriteLine("¡Un pokémon salvaje atacó al equipo!");
                                Console.WriteLine("Daño recibido por todos: " + Num);
                                Console.WriteLine("");
                                Console.WriteLine("Las vidas fueron actualizadas.");
                            }
                            else if (vidasPokemones.Length == 1)
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
                            if (vidasPokemones.Length > 0)
                            {
                                int maxVida = vidasPokemones[0];
                                int posicionMax = 0;
                                for (int i = 1; i < vidasPokemones.Length; i++)
                                {
                                    if (vidasPokemones[i] > maxVida)
                                    {
                                        maxVida = vidasPokemones[i];
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
                            if (vidasPokemones.Length > 0)
                            {
                                int minVida = vidasPokemones[0];
                                int posicionMin = 0;
                                for (int i = 1; i < vidasPokemones.Length; i++)
                                {
                                    if (vidasPokemones[i] < minVida)
                                    {
                                        minVida = vidasPokemones[i];
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
                        int PromVida = vidasPokemones.Sum() / vidasPokemones.Length;
                        if (PromVida >= 70)
                        {
                            Console.WriteLine("El equipo está en buen estado.");
                        }
                        else if (PromVida >= 31 && PromVida <= 69)
                        {
                            Console.WriteLine("El equipo necesita curación.");
                        }
                        else
                        {
                            Console.WriteLine("El equipo está en peligro.");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "10":
                        Console.WriteLine("Vidas ordenadas de menor a mayor:");
                        Console.WriteLine("");
                        Array.Sort(vidasPokemones);
                        foreach (int i in vidasPokemones)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "11":
                        Console.WriteLine("Vidas ordenadas de mayor a menor:");
                        Console.WriteLine("");
                        Array.Sort(vidasPokemones);
                        Array.Reverse(vidasPokemones);
                        foreach (int i in vidasPokemones)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "12":
                        {
                            if (vidasPokemones.Length >= 2)
                            {
                                Console.WriteLine("Pokemones Debilitados");
                                int l = 0;
                                bool debilitado = false;
                                foreach (int i in vidasPokemones)
                                {
                                    l++;
                                    if (vidasPokemones[i] == 0)
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
                          else if (vidasPokemones.Length == 1)
                            {
                               if (vidasPokemones[0] > 0)
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
                        for (int i = 0; i < vidasPokemones.Length; i++)
                        {
                            vidasPokemones[i] = 100;
                        }
                        Console.WriteLine("Todos tus pokemones fueron curados al maximos!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "14":
                            string confirmacion = "";
                            while (confirmacion.ToLower() != "no")
                            {
                                confirmacion = "";
                                Console.Write("Seguro? ");
                                confirmacion = Console.ReadLine();
                                switch (confirmacion.ToLower())
                                {
                                    case "si":
                                        Console.WriteLine("Gracias por utilizar el sistema del Centro Poké-Remedio.");
                                        Console.ReadKey();
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
=======
﻿using System;
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
            int[] vidasPokemones = new int[0];
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
                Console.WriteLine("> 13. Usar Pocion Maxima");
                Console.WriteLine("> 14. Salir");

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
                        if (vidasPokemones.Length + cantpokemones > 6)
                        {
                            Console.CursorTop--;
                            Console.Write(new string(' ', Console.WindowWidth));
                            Console.CursorTop--;
                            Console.WriteLine("No puedes tener más de 6 pokemones en total. Actualmente tienes: " + vidasPokemones.Length);
                        }
                        else
                        {
                            int posicionInicial = vidasPokemones.Length;
                            Array.Resize(ref vidasPokemones, vidasPokemones.Length + cantpokemones);
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("Nota: Solo valores de 0 a 100 incluyentes seran considerados validos");
                            Console.WriteLine("");

                            for (int i = 0; i < cantpokemones;)
                            {
                                Console.Write("Ingrese la vida del pokémon N° " + (posicionInicial + i + 1) + ": ");
                                int NumPoke = int.Parse(Console.ReadLine());

                                if (NumPoke >= 0 && NumPoke <= 100)
                                {
                                    vidasPokemones[posicionInicial + i] = NumPoke;
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

                        if (vidasPokemones.Length > 1)
                        {
                            Console.WriteLine("Puntos de vida y estado de tu equipo");
                            Console.WriteLine("");
                            int l = 0;
                            foreach (int i in vidasPokemones)
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
                        else if (vidasPokemones.Length == 1)
                        {
                            Console.Write("Tu pokemon tiene" + vidasPokemones[0] + "de vida");
                            if (vidasPokemones[0] == 0)
                            {
                                Console.WriteLine("(Debilitado)");
                            }
                            else if (vidasPokemones[0] >= 1 && vidasPokemones[0] <= 30)
                            {
                                Console.WriteLine("(Estado critico)");
                            }
                            else if (vidasPokemones[0] >= 31 && vidasPokemones[0] <= 70)
                            {
                                Console.WriteLine("(Herido)");
                            }
                            else if (vidasPokemones[0] >= 71 && vidasPokemones[0] <= 100)
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
                        if (vidasPokemones.Length > 1)
                        {
                            Console.Write("Que pokémon curar? ");
                            int N_PKMN = int.Parse(Console.ReadLine());
                            int indice = N_PKMN - 1;
                            Console.Write("Por cuanto curar? ");
                            int CantCura = int.Parse(Console.ReadLine());
                            vidasPokemones[indice] = vidasPokemones[indice] + CantCura;
                            Console.WriteLine("El pokemon N° " + N_PKMN + " ha sido curado");
                            Console.WriteLine("Vida actual: " + vidasPokemones[indice]);
                        }
                        else if (vidasPokemones.Length == 1)
                        {
                            Console.Write("Por cuanto curar tu pokemon? ");
                            int CantCura = int.Parse(Console.ReadLine());
                            vidasPokemones[0] = vidasPokemones[0] + CantCura;
                            Console.WriteLine("Tu pokemon ha sido curado");
                            Console.WriteLine("Vida actual: " + vidasPokemones[0]);
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
                            if (vidasPokemones.Length > 1)
                            {
                                Console.Write("Que pokémon dañar? ");
                                int N_PKMN = int.Parse(Console.ReadLine());
                                int indice = N_PKMN - 1;
                                Console.Write("Por cuanto dañar? ");
                                int Cantdaño = int.Parse(Console.ReadLine());
                                vidasPokemones[indice] = vidasPokemones[indice] - Cantdaño;
                                Console.WriteLine("El pokemon N° " + N_PKMN + " ha sido dañado");
                                Console.WriteLine("Vida actual: " + vidasPokemones[indice]);
                            }
                            else if (vidasPokemones.Length == 1)
                            {
                                Console.Write("Por cuanto dañar tu pokemon? ");
                                int Cantdaño = int.Parse(Console.ReadLine());
                                vidasPokemones[0] = vidasPokemones[0] - Cantdaño;
                                Console.WriteLine("Tu pokemon ha sido dañado");
                                Console.WriteLine("Vida actual: " + vidasPokemones[0]);
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
                            if (vidasPokemones.Length > 1)
                            {
                                Console.Write("Por cuanto curar a todo tu equipo? ");
                                int CantCura = int.Parse(Console.ReadLine());
                                foreach (int i in vidasPokemones)
                                {
                                    vidasPokemones[i] = vidasPokemones[i] + CantCura;
                                }
                                Console.WriteLine("Tus pokemones fueron curados");
                            }
                            else if (vidasPokemones.Length == 1)
                            {
                                Console.Write("Por cuanto curar tu pokemon? ");
                                int CantCura = int.Parse(Console.ReadLine());
                                vidasPokemones[0] = vidasPokemones[0] + CantCura;
                                Console.WriteLine("Tu pokemon ha sido curado");
                                Console.WriteLine("Vida actual: " + vidasPokemones[0]);
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
                            if (vidasPokemones.Length > 1)
                            {
                                Console.WriteLine("¡Un pokémon salvaje atacó al equipo!");
                                Console.WriteLine("Daño recibido por todos: " + Num);
                                Console.WriteLine("");
                                Console.WriteLine("Las vidas fueron actualizadas.");
                            }
                            else if (vidasPokemones.Length == 1)
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
                            if (vidasPokemones.Length > 0)
                            {
                                int maxVida = vidasPokemones[0];
                                int posicionMax = 0;
                                for (int i = 1; i < vidasPokemones.Length; i++)
                                {
                                    if (vidasPokemones[i] > maxVida)
                                    {
                                        maxVida = vidasPokemones[i];
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
                            if (vidasPokemones.Length > 0)
                            {
                                int minVida = vidasPokemones[0];
                                int posicionMin = 0;
                                for (int i = 1; i < vidasPokemones.Length; i++)
                                {
                                    if (vidasPokemones[i] < minVida)
                                    {
                                        minVida = vidasPokemones[i];
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
                        int PromVida = vidasPokemones.Sum() / vidasPokemones.Length;
                        if (PromVida >= 70)
                        {
                            Console.WriteLine("El equipo está en buen estado.");
                        }
                        else if (PromVida >= 31 && PromVida <= 69)
                        {
                            Console.WriteLine("El equipo necesita curación.");
                        }
                        else
                        {
                            Console.WriteLine("El equipo está en peligro.");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "10":
                        Console.WriteLine("Vidas ordenadas de menor a mayor:");
                        Console.WriteLine("");
                        Array.Sort(vidasPokemones);
                        foreach (int i in vidasPokemones)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "11":
                        Console.WriteLine("Vidas ordenadas de mayor a menor:");
                        Console.WriteLine("");
                        Array.Sort(vidasPokemones);
                        Array.Reverse(vidasPokemones);
                        foreach (int i in vidasPokemones)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "12":
                        {
                            if (vidasPokemones.Length >= 2)
                            {
                                Console.WriteLine("Pokemones Debilitados");
                                int l = 0;
                                bool debilitado = false;
                                foreach (int i in vidasPokemones)
                                {
                                    l++;
                                    if (vidasPokemones[i] == 0)
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
                          else if (vidasPokemones.Length == 1)
                            {
                               if (vidasPokemones[0] > 0)
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
                        for (int i = 0; i < vidasPokemones.Length; i++)
                        {
                            vidasPokemones[i] = 100;
                        }
                        Console.WriteLine("Todos tus pokemones fueron curados al maximos!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "14":
                            string confirmacion = "";
                            while (confirmacion.ToLower() != "no")
                            {
                                confirmacion = "";
                                Console.Write("Seguro? ");
                                confirmacion = Console.ReadLine();
                                switch (confirmacion.ToLower())
                                {
                                    case "si":
                                        Console.WriteLine("Gracias por utilizar el sistema del Centro Poké-Remedio.");
                                        Console.ReadKey();
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
>>>>>>> e85c2b0bfe169f9bf4d6381e0494998342593a06
