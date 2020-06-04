using System;

public class Zero : Vehicle // Electric motorcycle
{
    public double BatteryKWh { get; set; }

    public override void Drive()
    {
        Console.WriteLine("SKEET SKEET!");
    }

    public override void Turn()
    {
        Console.WriteLine("The electric motorcycle smoothly takes a right turn!");
    }

    public override void Stop()
    {
        Console.WriteLine("The vehicle suddenly comes to a stop!");
    }


    public void ChargeBattery()
    {
        // method definition omitted
    }
}