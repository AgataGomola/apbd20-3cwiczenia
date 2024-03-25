using System;
using System.Collections.Generic;

namespace Tutorial3.Containers
{
    public class Ship
    {
        private List<Container> Containers;
        public double MaxSpeed;
        public int MaxContainers;
        public double MaxContainersWeight;
        private double currentContainersWeight = 0;

        public Ship(double maxSpeed, int maxContainers, double maxConteinersWeight)
        {
            Containers = new List<Container>();
            MaxSpeed = maxSpeed;
            MaxContainers = maxContainers;
            MaxContainersWeight = maxConteinersWeight;
        }

        public void LoadContainer(Container container)
        {
            if (Containers.Count < MaxContainers && currentContainersWeight + container.CargoWeight + container.Weight <= MaxContainersWeight)
            {
                Containers.Add(container);
                currentContainersWeight += container.CargoWeight;
            }
            else
            {
                Console.WriteLine("Cannot add another container.");
            }
        }
        public void LoadContainer(List<Container> containersList)
        {
            foreach (var c in containersList)
            {
                LoadContainer(c);
            }
        }   

        public void UnloadContainer(Container container)
        {
            if (Containers.Remove(container))
            {
                currentContainersWeight -= container.CargoWeight;
            }
        }

        public void ReplaceContainer(string toReplace, Container newContainer)
        {
            for (int i = 0; i < Containers.Count; i++)
            {
                if (Containers[i].SerialNumber == toReplace)
                {
                    currentContainersWeight -= Containers[i].CargoWeight + Containers[i].CargoWeight;
                    Containers[i] = newContainer;
                    currentContainersWeight += newContainer.CargoWeight + newContainer.Weight;
                    return;
                }    
            }
            Console.WriteLine("Container not found.");
            
        }

        public void MoveContainer(Container cont, Ship newShip)
        {
            Containers.Remove(cont);
            currentContainersWeight -= cont.CargoWeight - cont.Weight;
            newShip.LoadContainer(cont);
        }

        public void ShipInfo()
        {
            Console.WriteLine($"Max speed: {MaxSpeed}");
            Console.WriteLine($"Max containers: {MaxContainers}");
            Console.WriteLine($"Max weight of containers: {MaxContainersWeight} t");
            Console.WriteLine($"Current weight of containers: {currentContainersWeight} t");
            Console.WriteLine("Containers on the ship: ");
            foreach (var container in Containers)
            {
                Console.WriteLine($"Container serial number: {container.SerialNumber}, Cargo weight: {container.CargoWeight} t");
            }
            
        }
        

        }
    }