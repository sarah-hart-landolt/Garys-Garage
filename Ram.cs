using System;

namespace GarysWholesaleGarage
{
    public class Ram : Vehicle, IPetrol // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        // public void RefuelTank()
        // {
        //     // method definition omitted
        // }
        public override void Drive()
        {
            Console.WriteLine("Everyone pay attention to me!");
        }

        public override void Turn()
        {
            Console.WriteLine("The Dodge Ram obnoxiously takes a right turn!");
        }

        public override void Stop()
        {
            Console.WriteLine("After 2 miles, it comes to a screaching halt!");
        }

        public void RefuelTank()
        {
             CurrentTankPercentage = 100;
        }
    }
}