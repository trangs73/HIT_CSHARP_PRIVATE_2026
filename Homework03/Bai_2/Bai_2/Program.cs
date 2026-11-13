using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Queue<string> names = new Queue<string>(); 

        Stack<string> history = new Stack<string>();

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            names.Enqueue(name);
        }

        while (names.Count > 0)
        {
            string name = names.Dequeue();
            Console.WriteLine($"Phuc vu: {name}");
            history.Push(name);
        }

        if (history.Count > 0)
        {
            Console.WriteLine($"Gan nhat: {history.Peek()}");
        }
        else
        {
            Console.WriteLine("Chua phuc vu ai");
        }
    }
}