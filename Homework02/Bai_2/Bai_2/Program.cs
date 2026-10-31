using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so don danh: ");
        int n = int.Parse(Console.ReadLine());

        int hits = 0;
        int misses = 0;
        int[] damages = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Sat thuong don danh thu " + (i + 1) + ": ");
            damages[i] = int.Parse(Console.ReadLine());

            if (damages[i] > 0) hits++;
            else misses++;
        }

        int maxDamage = damages[0];
        for (int i = 0; i < n; i++)
        {
            if (damages[i] > maxDamage)
            {
                maxDamage = damages[i];
            }
        }

        int totalDamage = CalculateTotalDamage(damages);

        Console.WriteLine("Tong sat thuong: " + totalDamage);
        Console.WriteLine("So don danh trung: " + hits);
        Console.WriteLine("So don danh truot: " + misses);
        Console.WriteLine("Sat thuong lon nhat: " + maxDamage);
    }

    static int CalculateTotalDamage(int[] damages)
    {
        int total = 0;
        for (int i = 0; i < damages.Length; i++)
        {
            total += damages[i];
        }
        return total;
    }
}