using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
        string msg = "ctOS";
        string enc = Level4.CaesarPlusOne(msg);
        bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T
        Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");
        Console.ReadKey();
    }
}

static class Level4
{
    public static string CaesarPlusOne(string s)
    {
        // TODO: implementar
        // Reglas: letras rotan (z→a, Z→A), mantener may/min; otros chars, igual.
        if (string.IsNullOrEmpty(s)) return s;

        StringBuilder resultado = new StringBuilder();

        foreach (char c in s)
        {
            if (char.IsLower(c))
            {
                // Desplazamiento +1 con retorno cíclico (wrap-around) para minúsculas
                char rotado = (char)('a' + (c - 'a' + 1) % 26);
                resultado.Append(rotado);
            }
            else if (char.IsUpper(c))
            {
                // Desplazamiento +1 con retorno cíclico (wrap-around) para mayúsculas
                char rotado = (char)('A' + (c - 'A' + 1) % 26);
                resultado.Append(rotado);
            }
            else
            {
                // Si es un número, espacio o signo, se mantiene idéntico
                resultado.Append(c);
            }
        }

        return resultado.ToString();
        // Fin del TODO
    }
}
