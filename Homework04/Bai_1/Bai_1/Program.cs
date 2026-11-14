using System;
using System.Collections.Generic;

class Magazine
{
    private int _ammo;
    private readonly int _capacity;

    public string Name { get; }
    public int Ammo => _ammo;
    public int Capacity => _capacity;

    public Magazine(string name, int capacity)
    {
        Name = name;
        _capacity = capacity;
        _ammo = capacity;
    }

    public void Shoot(int amount)
    {
        if (amount <= 0) return;
        
        _ammo = Math.Max(0, _ammo - amount);
    }

    public void Reload(int amount)
    {
        if (amount <= 0) return;

        _ammo += Math.Min(amount, _capacity - _ammo);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Magazine armor = new Magazine("Armor", 6);
        Magazine swift = new Magazine("Swift", 4);

        Console.WriteLine($"{armor.Name}: {armor.Ammo}/{armor.Capacity}");

        armor.Shoot(2);
        Console.WriteLine($"{armor.Name}: {armor.Ammo}/{armor.Capacity}");

        armor.Reload(5);
        Console.WriteLine($"{armor.Name}: {armor.Ammo}/{armor.Capacity}");

        armor.Shoot(10);
        Console.WriteLine($"{armor.Name}: {armor.Ammo}/{armor.Capacity}");

        armor.Reload(-1);
        Console.WriteLine($"{armor.Name}: {armor.Ammo}/{armor.Capacity}");

        Console.WriteLine($"{swift.Name}: {swift.Ammo}/{swift.Capacity}");
    }
}