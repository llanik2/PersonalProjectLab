using System;
namespace PersonalProjectLab
{
    public class Calcuations
    {
        public Calcuations()
        {
           


        }

        public double CalculateFuel(Double NumItemUnits, Double FuelEff)
        {
            return Math.Ceiling(NumItemUnits / FuelEff);
        }

        public double CalculateItems(Double NumFuelUnits, Double FuelEff)
        {
            return NumFuelUnits * FuelEff;
        }
    }
}
