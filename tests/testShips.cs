// this file tests the Ships Class definitions
using ship = Ship.Ship; // importing static class
namespace TestShips
{
    public class ShipTester
    {
        private void PrintShip(ship ship)
        {
            Console.WriteLine("{0}: {1}", "shipClass", ship.getShipClass());
            Console.WriteLine("{0}: {1}", "spaces", ship.getSpaces());
            Console.WriteLine("{0}: {1}", "alignment", ship.getAlignment());
            Console.WriteLine("{0}: {1}", "coords", ship.getCoords());
            // new line to space thigs out
            Console.WriteLine("\n");
        }
        public void testShipConstructors()
        {
            // new carrier
            ship carrier = new ship("carrier", 5, "horizontal", "B4");
            PrintShip(carrier);
            // new battleship
            ship battleship = new ship("battleship", 4, "vertical", "C5");
            PrintShip(battleship);
            // new cruiser
            ship cruiser = new ship("cruiser", 3, "vertical", "D5");
            PrintShip(cruiser);
            // new submarine
            ship submarine = new ship("submarine", 3, "horizontal", "D5");
            PrintShip(submarine);
            // new destroyer
            ship destroyer = new ship("destroyer", 2, "vertical", "E8");
            PrintShip(destroyer);
        }

        public ShipTester() { }
    }

}