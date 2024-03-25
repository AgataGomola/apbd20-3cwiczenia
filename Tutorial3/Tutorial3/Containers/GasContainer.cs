using System;
using Tutorial3.Interfaces;

namespace Tutorial3.Containers
{
    public class GasContainer: Container, IHazardNotifier
    {
        private double Pressure;

        public GasContainer(double cargoWeight, double height, double weight, double depth, double maxCargoWeight, double pressure) : base("G", cargoWeight, height, weight, depth, maxCargoWeight)
        {
            Pressure = pressure;
        }

        public override void UnLoad()
        {
            CargoWeight *= 0.95;
            base.UnLoad();
        }

        public override void Load(double cargoWeight)
        {
            Console.WriteLine("Gas container loaded");
            base.Load(cargoWeight);
        }

        public void Notify()
        {
            Console.Write("Dangerous situation has occur in container number: "+ SerialNumber);
           
        }
    }
}