using System;
using System.Collections.Generic;

namespace Bai_2
{
    public class Program
    {
        static void HitAll<T>(List<T> targets, int damage) where T : IGetHit
        {
            foreach (T target in targets) {
                target.GetHit(damage);
            }
        }

        static void Main()
        {
            List<Tank> tanks = new List<Tank>();
            tanks.Add(new Tank("Alpha", 100));
            tanks.Add(new Tank("Beta", 60));

            List<WoodenCrate> woodenCrates = new List<WoodenCrate>();
            woodenCrates.Add(new WoodenCrate("Box", 10));

            HitAll(tanks, 20);
            HitAll(woodenCrates, 20);

            foreach (Tank tank in tanks) {
                Console.WriteLine($"{tank.Name}: {tank.Hp}");
            }

            foreach (WoodenCrate woodenCrate in woodenCrates)
            {
                Console.WriteLine($"{woodenCrate.Name}: {woodenCrate.Hp}");
            }
        }
    }
}