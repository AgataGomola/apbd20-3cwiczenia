using System;
using Tutorial3.Exceptions;
using Tutorial3.Interfaces;

namespace Tutorial3.Containers
{
    public class LiquidContainer: Container, IHazardNotifier
    {
        private bool isDangerous;

        public LiquidContainer(double cargoWeight, double height, double weight, double depth, double maxCargoWeight, bool isDangerous) : base("L", cargoWeight, height, weight, depth, maxCargoWeight)
        {
            this.isDangerous = isDangerous;
        }

        public override void Load(double cargoWeight)
        {
            double maxWeight = 0.9;
            if (isDangerous)
            {
                maxWeight = 0.5;
            }

            if ((CargoWeight + cargoWeight) > maxWeight * MaxCargoWeight)
            {
                Notify();
                throw new OverfillException("Maximum payload has been exceeded");
            }
            else
            {
                base.Load(cargoWeight);
                Console.WriteLine("Liquid container loaded");   
            }
        }

        public void Notify()
        {
            Console.WriteLine("Dangerous situation has occur in container number: " + SerialNumber);
        }
    }
}