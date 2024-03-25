using Tutorial3.Containers;

namespace Tutorial3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            LiquidContainer liquidContainer = new LiquidContainer(1000, 200, 100, 150, 5000, true);
            GasContainer gasContainer = new GasContainer(800, 150, 80, 120, 2000, 10.5);
            ChilledContainer chilledContainer = new ChilledContainer(500, 120, 70, 100, 1000, PossibleProducts.Meat, 2);

            liquidContainer.Load(500);
            gasContainer.Load(600);
            chilledContainer.Load(300);
            
            liquidContainer.ContainerInfo();
            gasContainer.ContainerInfo();
            chilledContainer.ContainerInfo();
            
            Ship ship = new Ship(20, 10, 10000);
            
            ship.LoadContainer(liquidContainer);
            ship.LoadContainer(gasContainer);
            ship.LoadContainer(chilledContainer);
            
            ship.ShipInfo();
            
            ship.UnloadContainer(liquidContainer);
            
            ship.ShipInfo();
            
            Ship anothership = new Ship(25, 15, 15000);
            ship.MoveContainer(chilledContainer, anotherShip);
            
            ship.ShipInfo();
            anotherShip.ShipInfo();
        }
    }
}