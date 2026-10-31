using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so luong nguoi choi: ");
        int n = int.Parse(Console.ReadLine());

        string topPlayer = "";
        int maxScore = -1;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap ten nguoi choi: ");
            string name = Console.ReadLine();
            Console.Write("Nhap so diem ha guc: ");
            int kills = int.Parse(Console.ReadLine());
            Console.Write("Nhap so diem ho tro: ");
            int assists = int.Parse(Console.ReadLine());

            int score = CalculateScore(kills, assists);
            Console.WriteLine(name + ": " + score + " diem");
            Console.WriteLine();

            if (score > maxScore)
            {
                maxScore = score;
                topPlayer = name;
            }
        }

        Console.WriteLine("Dan dau: " + topPlayer);
        Console.WriteLine("Diem cao nhat: " + maxScore);
    }

    static int CalculateScore(int kills, int assists)
    {
        return kills * 100 + assists * 30;
    }
}