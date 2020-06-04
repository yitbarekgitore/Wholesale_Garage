using System;

public class Ram:Vehicle  // Gas powered truck
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        System.Console.WriteLine($"Fuel capacity {FuelCapacity}");
    }
    public override void Drive()
    {
        Console.WriteLine("zoom!");
    }
    public override void Direction(string direction)
    {
        Console.WriteLine($"Ram turns {direction}");
    }
}