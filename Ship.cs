// A class to create ship objects.
// Each ship object represents one of the ship pieces from the gameboard.
namespace Ship
{
    public class Ship
    {
        // fields of class
        // These are private fields to ensure mutability only through setter methods
        private string shipClass; // class of battleship [carrier, battleship, cruiser, submarine, destroyer]
        private int spaces; // how many spaces the battleship takes up [carrier = 5, battleship = 4, cruiser = 3, submarine = 3, destroyer = 2]
        private string alignment; // if the ship is aligned ['vertical', 'horizontal']
        private string coords; // coordinates for which the ship is centered. Eg "D2".

        // getter methods
        public string getShipClass() { return this.shipClass; }
        public int getSpaces() { return this.spaces; }
        public string getAlignment() { return this.alignment; }
        public string getCoords() { return this.coords; }

        // setter methods
        public void setShipClass(string shipClass)
        {
            this.shipClass = shipClass;
        }
        public void setSpaces(int spaces)
        {
            // TODO: ideally spaces is set based on what form the ship object is
            // for now this will do.
            this.spaces = spaces;
        }

        public void setAlignment(string alignment)
        {
            // TODO: ideally, check alignment string is in range ['horizontal', 'vertical']
            // for now, this will do.
            this.alignment = alignment;
        }
        public void setCoords(string coords)
        {
            // TODO: need to validate coord strings are in ideal format. Eg, "A1" -> "J10"
            this.coords = coords;
        }

        // constructors
        public Ship() { }
        public Ship(string shipClass, int spaces, string alignment, string coords)
        {
            this.shipClass = shipClass;
            this.spaces = spaces;
            this.alignment = alignment;
            this.coords = coords;
        }

    }

}
