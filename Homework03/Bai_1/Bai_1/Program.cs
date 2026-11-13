using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<string> items = new List<string>();

        Dictionary<string, int> counts = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            string item = Console.ReadLine();
            items.Add(item);

            if (counts.ContainsKey(item))
            {
                counts[item]++;
            }
            else
            {
                counts.Add(item, 1);
            }
        }

        string searchItem = Console.ReadLine();
        string removeItem = Console.ReadLine();

        int count = 0;
        counts.TryGetValue(searchItem, out count);

        bool removed = items.Remove(removeItem);

        if (removed)
        {
            counts[removeItem]--;

            if (counts[removeItem] == 0 )
            {
                counts.Remove(removeItem);
            }
        }
        else
        {
            Console.WriteLine("Khong co vat pham");
        }

        Console.WriteLine($"Da nhat: {n}");
        Console.WriteLine($"So luong tra cuu: {count}");

        if (items.Count == 0)
        {
            Console.WriteLine("(rong)");
        }
        else
        {
            Console.Write("Con lai: " + string.Join(" ", items));
        }
    }
}