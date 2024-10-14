using System;
using System.Collections.Generic;

namespace MultiProblemSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Spiral Matris
            Console.WriteLine("1. Spiral Matris");
            SpiralMatrix(5);

            // 2. İki Matrisin Çarpımı
            Console.WriteLine("\n2. İki Matrisin Çarpımı");
            MultiplyMatrices();

            // 3. N'e Kadar Asal Sayıların Toplamı
            Console.WriteLine("\n3. N'e Kadar Asal Sayıların Toplamı");
            SumOfPrimes();

            // 4. Robotların Düğüm Kurtarma
            Console.WriteLine("\n4. Robotların Düğüm Kurtarma");
            RescueNodes();

            // 5. Labirentte En Kısa Yol
            Console.WriteLine("\n5. Labirentte En Kısa Yol");
            FindShortestPath();
        }

        // 1. Spiral Matris
        static void SpiralMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int left = 0, right = n - 1, top = 0, bottom = n - 1;
            int num = 1;

            while (left <= right && top <= bottom)
            {
                for (int i = left; i <= right; i++) matrix[top, i] = num++;
                top++;
                for (int i = top; i <= bottom; i++) matrix[i, right] = num++;
                right--;
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--) matrix[bottom, i] = num++;
                    bottom--;
                }
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--) matrix[i, left] = num++;
                    left++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // 2. İki Matrisin Çarpımı
        static void MultiplyMatrices()
        {
            Console.Write("Matris boyutunu girin (NxN): ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrixA = new int[n, n];
            int[,] matrixB = new int[n, n];
            int[,] result = new int[n, n];

            Console.WriteLine("1. Matrisin elemanlarını girin:");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrixA[i, j] = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Matrisin elemanlarını girin:");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrixB[i, j] = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < n; k++)
                        result[i, j] += matrixA[i, k] * matrixB[k, j];

            Console.WriteLine("Çarpım Matris:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // 3. N'e Kadar Asal Sayıların Toplamı
        static void SumOfPrimes()
        {
            Console.Write("Bir N sayısı girin: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i)) sum += i;
            }

            Console.WriteLine($"1'den {n}'e kadar olan asal sayıların toplamı: {sum}");
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        // 4. Robotların Düğüm Kurtarma
        static void RescueNodes()
        {
            int[,] grid = {
                { 1, 1, 0, 1 },
                { 0, 1, 0, 0 },
                { 1, 1, 1, 0 },
                { 0, 0, 1, 1 }
            };

            Robot[] robots = { new Robot(0, 0), new Robot(2, 2), new Robot(3, 3) };
            HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>();
            int totalRescued = 0;

            foreach (var robot in robots)
            {
                totalRescued += Rescue(grid, robot.X, robot.Y, visited);
            }

            Console.WriteLine($"Toplam kurtarılan düğüm sayısı: {totalRescued}");
        }

        static int Rescue(int[,] grid, int x, int y, HashSet<Tuple<int, int>> visited)
        {
            if (x < 0 || x >= grid.GetLength(0) || y < 0 || y >= grid.GetLength(1) || grid[x, y] == 0 || visited.Contains(Tuple.Create(x, y)))
                return 0;

            visited.Add(Tuple.Create(x, y));
            int count = 1; // Current node

            // Move in all four directions
            count += Rescue(grid, x + 1, y, visited);
            count += Rescue(grid, x - 1, y, visited);
            count += Rescue(grid, x, y + 1, visited);
            count += Rescue(grid, x, y - 1, visited);

            return count;
        }

        class Robot
        {
            public int X { get; }
            public int Y { get; }

            public Robot(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        // 5. Labirentte En Kısa Yol
        static void FindShortestPath()
        {
            int[,] maze = {
                { 1, 0, 0, 0 },
                { 1, 1, 0, 1 },
                { 0, 1, 1, 1 },
                { 0, 0, 0, 1 }
            };

            int steps = ShortestPath(maze, 0, 0, maze.GetLength(0) - 1, maze.GetLength(1) - 1);
            if (steps == -1)
                Console.WriteLine("Yol Yok");
            else
                Console.WriteLine($"En Kısa Yol: {steps} adım");
        }

        static int ShortestPath(int[,] maze, int startX, int startY, int endX, int endY)
        {
            if (maze[startX, startY] == 0 || maze[endX, endY] == 0)
                return -1;

            int n = maze.GetLength(0);
            bool[,] visited = new bool[n, n];
            int steps = 0;
            Queue<Position> queue = new Queue<Position>();
            queue.Enqueue(new Position(startX, startY, steps));
            visited[startX, startY] = true;

            int[] dirX = { -1, 1, 0, 0 };
            int[] dirY = { 0, 0, -1, 1 };

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                int x = current.X;
                int y = current.Y;
                steps = current.Steps;

                if (x == endX && y == endY)
                    return steps;

                for (int i = 0; i < 4; i++)
                {
                    int newX = x + dirX[i];
                    int newY = y + dirY[i];

                    if (newX >= 0 && newX < n && newY >= 0 && newY < n && maze[newX, newY] == 1 && !visited[newX, newY])
                    {
                        visited[newX, newY] = true;
                        queue.Enqueue(new Position(newX, newY, steps + 1));
                    }
                }
            }

            return -1; // Path not found
        }

        class Position
        {
            public int X { get; }
            public int Y { get; }
            public int Steps { get; }

            public Position(int x, int y, int steps)
            {
                X = x;
                Y = y;
                Steps = steps;
            }
        }
    }
}
