using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        const int PointsPerEnemy = 150;

        int enemyCount = int.Parse(Console.ReadLine() ?? "0");

        int totalSeconds = int.Parse(Console.ReadLine() ?? "0");

        int totalPoints = enemyCount * PointsPerEnemy;

        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        double enemiesPerMinute = enemyCount * 60.0 / totalSeconds;

        Console.WriteLine("Diem: " + totalPoints);
        Console.WriteLine("Thoi gian: " + minutes + " phut " + seconds + " giay");
        Console.WriteLine("Dich/phut: " + enemiesPerMinute.ToString("F2", CultureInfo.InvariantCulture));
    }
}