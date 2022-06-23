// Class to store the state of the game board for a player.
// This class will track the state of each player.
using ship = Ship.Ship;

namespace PayerBoard
{

    public class PlayerBoard
    {
        // @fields
        private bool hasWon;            // determine if player has won so as to exit the game.
        private List<string> hits;      // list of coordinates where there have been hits.
        private List<string> misses;    // list of coordinates where there have been misses.
        private List<ship> ships;       // List of all ships.

        // @getter_methods
        public bool getHasWon() { return hasWon; }
        public List<string> getHits() { return hits; }
        public List<string> getMisses() { return misses; }
        public List<ship> getShips() { return ships; }
        // @setter_methods
        // Set win state of player board
        public void setHasWon(bool won)
        {
            this.hasWon = won;
        }
        // add hits to the array of hits on player board
        public void addHit(string coords)
        {
            // TODO: validate coords string is correctly formatted.
            this.hits.Add(coords);
        }
        // add misses to the array of misses on the player board
        public void addMiss(string coords)
        {
            // TODO: validate coords string is correctly formatted.
            this.misses.Add(coords);
        }
        // add ship to the array of ships on player board
        // NOTE: this will probably not be used but is good to have for debugging.
        public void addShip(ship ship)
        {
            // since ship parameters will be validated in ship object,
            // no need to validate here.
            this.ships.Add(ship);
        }
        // remove a specific hit from the hits list
        public void removeHit(string coords)
        {
            // Every hit is a unique string so there shouldn't be
            // any duplicate occurances.
            this.hits.Remove(coords);
        }
        // remove a specific miss from the misses list
        public void removeMiss(string coords)
        {
            // Every miss is a unique string so there shouldn't be
            // any duplicate occurances.
            this.misses.Remove(coords);
        }
        // remove a ship.
        // this will be used to remove ships when they have been sunk.
        public void removeShip(ship ship)
        {
            // Unique occurances of ships guaranteed.
            this.ships.Remove(ship);
        }

        // @methods
        public void printBoardWithoutShips()
        {
            // this method prints the board without ships
            // this method is meant to show the oposing player the state
            // of this board.
        }

        public void printBoardWithShips()
        {
            // This method is meant to show the player's own game board.
            // They will need to know where their own ships are.
        }

    }
}

