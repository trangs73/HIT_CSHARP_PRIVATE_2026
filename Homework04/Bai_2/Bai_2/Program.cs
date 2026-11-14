using System;
using System.Collections.Generic;
using System.ComponentModel;

abstract class MissionTank
{
    public string Name { get; }
    
    public MissionTank(string name)
    {
        Name = name;
    }

    public abstract int PerformMission();

    public virtual string Describe()
    {
        return "Xe: " + Name;
    }
}

class Scanner
{
    public int Scan()
    {
        return 20;
    }
}

class ScoutTank : MissionTank
{
    private Scanner _scanner = new Scanner();

    public ScoutTank(string name) : base(name) { }

    public override int PerformMission()
    {
        //return 20;
        return _scanner.Scan();
    }

    public override string Describe()
    {
        return base.Describe() + " [Trinh sat]";
    }
}

class RepairTank : MissionTank
{
    public RepairTank(string name) : base(name) { }

    public override int PerformMission()
    {
        return 35;
    }

    public override string Describe()
    {
        return base.Describe() + " [Sua chua]";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<MissionTank> list = new List<MissionTank>
        {
            new ScoutTank("Swift"),
            new RepairTank("Fixer"),
            new ScoutTank("Echo")
        };

        int totalPoints = 0;
        foreach (MissionTank tank in list)
        {
            totalPoints += tank.PerformMission();

            Console.WriteLine($"{tank.Describe()} | Diem: {tank.PerformMission()}");
        }

        Console.WriteLine("Tong diem: " + totalPoints);
    }
}