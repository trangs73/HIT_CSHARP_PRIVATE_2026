using System;
using System.Collections.Generic;

static class MatchSetup
{
    public const int MaxPlayers = 4;
    
    public static void Swap(ref int first,  ref int second)
    {
        int temp = first;
        first = second;
        second = temp;
    }
}

class PlayerProfile
{
    public string Name { get; }
    public PlayerProfile(string name) { Name = name; }
}

class Program
{
    static void Main(string[] args)
    {
        string[] inputs = { "2", "4", "0", "5", "abc", "1", "-1" };

        foreach (string text in inputs)
        {
            bool check = int.TryParse(text, out int count) && count >= 1 && count <= MatchSetup.MaxPlayers;
            Console.WriteLine($"{text}: {check}, {count}");
        }

        int first = 1;
        int second = 2;

        MatchSetup.Swap(ref first, ref second);
        Console.WriteLine($"Sau swap: {first}, {second}");

        PlayerProfile? profile = null;
        Console.WriteLine("Chu phong: " + (profile?.Name ?? "Guest"));

        profile = new PlayerProfile("HIT");
        Console.WriteLine("Chu phong: " + (profile?.Name ?? "Guest"));
    }
}