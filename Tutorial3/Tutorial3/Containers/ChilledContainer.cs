using System;

namespace Tutorial3.Containers
{
    public class ChilledContainer : Container
    {
        private double temperature;
        private PossibleProducts productType;

        public ChilledContainer(double cargoWeight, double height, double weight, double depth, double maxCargoWeight, PossibleProducts productType, double temperature) 
            : base("C", cargoWeight, height, weight, depth, maxCargoWeight)
        {
            this.productType = productType;
            this.temperature = temperature;
        }

        public override void Load(double cargoWeight)
        {
            double requiredTemperature = ProductTemperature.temperatures[productType];
            
            if (temperature < requiredTemperature)
            {
                Console.WriteLine("Temperature in this container is too low.");
            }
            else
            {
                Console.WriteLine("Chilled Container loaded");
                base.Load(cargoWeight);   
            }
        }
    }
}