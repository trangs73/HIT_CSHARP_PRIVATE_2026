using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_1
{
    public class WoodenCrate : IGetHit
    {
        public string Name { get; }
        public int Hp { get; private set; }

        public WoodenCrate(string name, int hp)
        {
            Name = name;
            Hp = hp;
        }

        public void GetHit(int damage)
        {
            if (damage <= 0) return;
            Hp = Math.Max(0, Hp - damage);
        }
    }
}
