// A class to create ship objects.
// Each ship object represents one of the ship pieces from the gameboard.
namespace Ship
{
    public class Ship
    {
        // @fields
        // These are private fields to ensure mutability only through setter methods
        private string shipClass; // class of battleship [carrier, battleship, cruiser, submarine, destroyer]
        private int hitPoints; // how many hits the battleship takes up [carrier = 5, battleship = 4, cruiser = 3, submarine = 3, destroyer = 2]
        private List<string> coords = new List<string>(); // coordinates for which the ship is centered. Eg "D2".

        // @getter_methods
        public string getShipClass() { return this.shipClass; }
        public int getHitPoints() { return this.hitPoints; }
        public List<string> getCoords() { return this.coords; }
        //@setter_methods
        public void setShipClass(string shipClass)
        {
            this.shipClass = shipClass;
        }
        public void setHitPoints(int hitPoints)
        {
            // TODO: ideally spaces is set based on what form the ship object is
            // for now this will do.
            this.hitPoints = hitPoints;
        }
        // add a coords string to the coords list for a ship
        public void addSingleCoord(string coords)
        {
            // TODO: need to validate coord strings are in ideal format. Eg, "A1" -> "J10"
            this.coords.Add(coords);
        }
        public void addCoordsList(List<string> coords)
        {
            // note that this will replace all the coords previously stored
            this.coords = coords;
        }

        // @methods
        public void printCoords()
        {
            // helper function to print coords if needed
            Console.Write(this.shipClass + " coords: ");
            this.coords.ForEach(item => { Console.Write(item + " "); });
            Console.WriteLine();
        }

        // @constructors
        public Ship() { }
        public Ship(string shipClass, int hitPoints, List<string> coords)
        {
            this.shipClass = shipClass;
            this.hitPoints = hitPoints;
            this.coords = coords;
        }

    }

}
