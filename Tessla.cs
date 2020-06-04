using System;

public class Tesla: Vehicle  // Electric car
{
    public double BatteryKWh { get; set; }
    public void ChargeBattery()
    {
        // method definition omitted
    }

     public override void Drive()
    {
        Console.WriteLine("Badda Bing Badda Boom!");
    }

    public override void Turn()
    {
        Console.WriteLine("The vehicle intuitively takes a left turn!");
    }

    public override void Stop()
    {
        Console.WriteLine("The Tesla silently stops as if it never moved!");
    }
}