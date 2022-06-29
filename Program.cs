using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int kitCount = int.Parse(Console.ReadLine() ?? "_");

        for (int _ = 0; _ < kitCount; _++)
        {
            Console.ReadLine();

            var inputDims = (Console.ReadLine() ?? "_")
                .Split(' ')
                .Select(t => int.Parse(t));
            int n = inputDims.ElementAt(0);
            int m = inputDims.ElementAt(1);

            var matrix = new List<int[]>(n);
            for (int __ = 0; __ < n; __++)
            {
                matrix.Add((Console.ReadLine() ?? "_")
                    .Split(' ')
                    .Select(t => int.Parse(t))
                    .ToArray());
            }

            int clickCount = int.Parse(Console.ReadLine() ?? "_");
            int[] clicked = (Console.ReadLine() ?? "_")
                .Split(' ')
                .Select(t => int.Parse(t))
                .ToArray();

            foreach (int click in clicked)
            {
                matrix = matrix.OrderBy(line => line[click - 1]).ToList();
            }

            for (int y = 0; y < n; y++)
            {
                Console.Write($"{matrix[y][0]}");
                for (int x = 1; x < m; x++)
                {
                    Console.Write($" {matrix[y][x]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}