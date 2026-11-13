using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        HashSet<string> achievements = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            string achievement = Console.ReadLine();
            achievements.Add(achievement);
        }

        string search = Console.ReadLine();

        Console.WriteLine($"Thanh tuu duy nhat: {achievements.Count}");
        Console.WriteLine($"Da mo khoa: {achievements.Contains(search)}");

        GridPosition original = new GridPosition();

        original.X = 2;
        original.Y = 3;

        GridPosition copy = original;
        copy.X = 99;

        Console.WriteLine($"Original: ({original.X}, {original.Y})");
        Console.WriteLine($"Copy: ({copy.X}, {copy.Y})");
    }

    struct GridPosition
    {
        public int X;
        public int Y;
    }
}