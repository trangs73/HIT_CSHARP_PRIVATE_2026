using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap luong mau ban dau: ");
        int initialHp = int.Parse(Console.ReadLine());

        Console.Write("Nhap luong giap co dinh: ");
        int armor = int.Parse(Console.ReadLine());

        Console.Write("Nhap so don tan cong: ");
        int n = int.Parse(Console.ReadLine());

        int[] attacks = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap don tan cong thu " + (i + 1) + ": ");
            attacks[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("====KET QUA====");

        int currentHp = initialHp;
        int totalHpLost = 0;
        int processedHits = 0;
        int finishingHit = 0;
        bool isDead = false;

        for (int i = 0;i < n; i++)
        {
            int damage = CalculateDamage(attacks[i], armor);
            int newHp = CalculateRemainingHp(currentHp, damage);
            totalHpLost += currentHp - newHp;
            currentHp = newHp;
            processedHits++;

            Console.WriteLine("Don " + (i + 1) + ": " + "Sat thuong " + damage + " | " + "HP " + newHp);

            if (totalHpLost == initialHp)
            {
                isDead = true;
                finishingHit = i + 1;
                break;
            }
        }

        if (!isDead) Console.WriteLine("Trang thai: Chua bi ha");
        else Console.WriteLine("Trang thai: Da bi ha");

        Console.WriteLine("So don da xu ly: " + processedHits);
        Console.WriteLine("Tong HP da mat: " + totalHpLost);
       
        if (totalHpLost == initialHp) Console.WriteLine("Don ket lieu: " + finishingHit);
        
    }

    static int CalculateDamage(int attack, int armor) 
    {
        int damage = attack - armor;
        if (damage < 0) return 0;
        else return damage;

    }

    static int CalculateRemainingHp(int currentHp, int damage)
    {
        int newHp = currentHp - damage;
        if (newHp < 0) return 0;
        else return newHp;
    }
}