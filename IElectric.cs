namespace GarysWholesaleGarage
{
    public interface IElectric
    {
        int CurrentChargePercentage { get; set; }
        void ChargeBattery();

    }
}