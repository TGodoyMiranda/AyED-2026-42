using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 3 – Firewalls adyacentes (LITE)");
        int[,] g =
        {
            {0,1,0},
            {1,0,1},
            {0,1,0}
        };
        bool ok = Level3.CountAdjacent(g, 1, 1) == 4
               && Level3.CountAdjacent(g, 0, 0) == 2;
        Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -OK" : "🔒 LOCKED");
        Console.ReadKey();
    }
}

static class Level3
{
    public static int CountAdjacent(int[,] grid, int row, int col)
    {
        // TODO: implementar
        // Considerar vecinos: (r-1,c), (r+1,c), (r,c-1), (r,c+1)
        // Devolver cuántos valen 1

        int count = 0;
        int maxRows = grid.GetLength(0);
        int maxCols = grid.GetLength(1);

        // Vecino de Arriba: (row - 1, col)
        if (row - 1 >= 0 && grid[row - 1, col] == 1) count++;

        // Vecino de Abajo: (row + 1, col)
        if (row + 1 < maxRows && grid[row + 1, col] == 1) count++;

        // Vecino de la Izquierda: (row, col - 1)
        if (col - 1 >= 0 && grid[row, col - 1] == 1) count++;

        // Vecino de la Derecha: (row, col + 1)
        if (col + 1 < maxCols && grid[row, col + 1] == 1) count++;

        return count;
        // Fin del TODO
    }
}

