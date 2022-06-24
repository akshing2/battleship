// this file tests the Ships Class definitions
using ship = Ship.Ship; // importing static class
namespace TestShips
{
    public class ShipTester
    {
        private void PrintShip(ship ship)
        {
            Console.WriteLine("{0}: {1}", "shipClass", ship.getShipClass());
            Console.WriteLine("{0}: {1}", "hitPoints", ship.getHitPoints());
            ship.printCoords();
            // new line to space thigs out
            Console.WriteLine("\n");
        }
        public void testShipConstructors()
        {
            // new carrier
            ship carrier = new ship("carrier", 5, new List<string>() { "A1", "A2", "A3", "A4", "A5" });
            PrintShip(carrier);
            // new battleship
            ship battleship = new ship("battleship", 4, new List<string>() { "A1", "A2", "A3", "A4" });
            PrintShip(battleship);
            // new cruiser
            ship cruiser = new ship("cruiser", 3, new List<string>() { "A1", "A2", "A3" });
            PrintShip(cruiser);
            // new submarine
            ship submarine = new ship("submarine", 3, new List<string>() { "A1", "A2", "A3" });
            PrintShip(submarine);
            // new destroyer
            ship destroyer = new ship("destroyer", 2, new List<string>() { "A1", "A2" });
            PrintShip(destroyer);
        }

        public ShipTester() { }
    }

}