using System;
using System.Collections.Generic;
using GarysWholesaleGarage;

public class Tesla: Vehicle, IElectric  // Electric car
{
    public double BatteryKWh { get; set; }
    public int CurrentChargePercentage { get; set; }

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

    public void ChargeBattery()
    {
        CurrentChargePercentage= 100;    
    }
}