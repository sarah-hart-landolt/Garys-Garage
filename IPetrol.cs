namespace GarysWholesaleGarage
{
    public interface IPetrol
    {
      int CurrentTankPercentage  { get; set; }
      void RefuelTank();
    }
}