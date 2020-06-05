using System;

namespace GarysWholesaleGarage
{
    public class Cessna : Vehicle, IPetrol
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }


        public override void Drive()
        {
            Console.WriteLine("Zoooooom!");
        }

        public void RefuelTank()
        {
             CurrentTankPercentage = 100;
        }
    }
}