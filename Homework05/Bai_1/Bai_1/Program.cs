using System;
using System.Linq.Expressions;

namespace Bai_1
{
    class Program {
        static void ApplyDamage(IGetHit target, int damage)
        {
            target.GetHit(damage);
        }

        static void Main()
        {
            Tank tank = new Tank("HIT", 100);
            WoodenCrate box = new WoodenCrate("Box", 30);

            ApplyDamage(tank, 40);
            ApplyDamage(box, 40);

            Console.WriteLine($"{tank.Name}: {tank.Hp}");
            Console.WriteLine($"{box.Name}: {box.Hp}");
        }
    }
}

