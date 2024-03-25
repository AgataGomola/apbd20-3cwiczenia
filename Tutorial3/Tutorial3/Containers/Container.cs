using System;
using Tutorial3.Exceptions;
using Tutorial3.Interfaces;

namespace Tutorial3.Containers
{
    public abstract class Container: IConteiner
    {
        public double CargoWeight { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Depth { get; set; }
        public string SerialNumber { get; set; }
        private string Type { get; set; }
        protected double MaxCargoWeight { get; set; }
        private static int _number = 1;


        protected Container(string type, double cargoWeight, double height, double weight, double depth, double maxCargoWeight)
        {
            CargoWeight = cargoWeight;
            Height = height;
            Weight = weight;
            Depth = depth;
            MaxCargoWeight = maxCargoWeight;
            Type = type;
            SerialNumber = GetSerialNumber();
        }

        public virtual void UnLoad()
        {
            Console.WriteLine("Unloaded cargo from container");
            CargoWeight = 0;
        }

        public virtual void Load(double cargoWeight)
        {
           
            if (CargoWeight + cargoWeight > MaxCargoWeight)
            {
                throw new OverfillException("Maximum payload has been exceeded");
            }
            else
            {
                CargoWeight += cargoWeight;
            }
        }

        private string GetSerialNumber()
        {
            return SerialNumber = "KON-"+ Type +"-"+ _number++;
        }
        public void ContainerInfo()
        {
            Console.WriteLine($"Serial number: {SerialNumber}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Cargo weight: {CargoWeight} t");
            Console.WriteLine($"Max cargo weight: {MaxCargoWeight} t");
        }
    }
}