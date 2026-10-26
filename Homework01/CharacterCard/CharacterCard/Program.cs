using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Nhap ten nhan vat: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Nhap HP: ");
        int hp = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap toc do: ");
        double speed = double.Parse(
            Console.ReadLine() ?? "0",
            CultureInfo.InvariantCulture);

        Console.Write("Nhap hang: ");
        char rank = char.Parse(Console.ReadLine() ?? "0");

        bool isAlive = hp > 0;

        Console.WriteLine("Ten: " + name);
        Console.WriteLine("HP: " + hp);
        Console.WriteLine(
            "Toc do: " + speed.ToString("F1", CultureInfo.InvariantCulture)
        );
        Console.WriteLine("Hang: " + rank);
        Console.WriteLine("Con song: " + isAlive);
    }
}

