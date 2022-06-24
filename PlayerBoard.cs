// Class to store the state of the game board for a player.
// This class will track the state of each player.
using ship = Ship.Ship;

namespace PlayerBoard
{

    public class PlayerBoard
    {
        // @fields
        private bool hasWon;            // determine if player has won so as to exit the game.
        private List<string> hits = new List<string>();      // list of coordinates where there have been hits.
        private List<string> misses = new List<string>();    // list of coordinates where there have been misses.
        private List<ship> ships = new List<ship>();       // List of all ships.
        private int numRows = 10;            // number of rows in game board (always 10)
        // Header labels for each row
        private string[] rowHeaders = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        private int numCols = 10;            // number of columns in game board (always 10)
        // header labels for eeach column
        private string[] colHeaders = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        private string[] markers = { " ", "O", "X" }; // { empty, miss, hit }
        // for debugging
        private bool debug = false;


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
        public void setDebug(bool db)
        {
            this.debug = db;
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

        // Methods to determine if coords are empty, miss or hit.
        private bool isHit(string coords) { return this.hits.Contains(coords); }
        private bool isMiss(string coords) { return this.misses.Contains(coords); }

        // Methods to Print the Board
        // @brief: funciton to print column headers
        private void PrintColumnHeaders()
        {
            Console.Write(" | "); // blank space for first header formatting
            for (int i = 0; i < numCols; i++)
            {
                // format header so that number of digits are uniform.
                // This will make the game board easier to read.
                string toWrite = this.colHeaders[i].Length == 1 ? " " + this.colHeaders[i] : this.colHeaders[i];
                Console.Write(toWrite + " | ");
            }
            PrintRowSeparator();

        }

        // @brief: function to print a row header
        private void PrintRowHeader(int index)
        {
            Console.Write(this.rowHeaders[index] + "|");
        }

        // @brief: function to print row sepatators
        private void PrintRowSeparator()
        {
            Console.WriteLine();
            string rowSeparator = new string('_', 52);
            Console.WriteLine(rowSeparator);
        }

        // @brief: function to print if current coords is a hit, miss or unshot
        private void PrintCell(string coords = "")
        {
            // cell to be printed (will be a hit, miss or empty)
            string hit = " X";
            string miss = " O";
            string empty = "  ";
            // determine which cell type to use (empty, miss or hit)
            string cell = this.debug ? coords : this.isHit(coords) ? hit : this.isMiss(coords) ? miss : empty;

            // write out the cell
            Console.Write(" " + cell + " |");

        }

        // @brief: This method prints the game board in the command line
        // @params:
        //  withShips   ->  (bool) print the board with the ships' coordinates.
        //                  This is to relay information to the player on where.
        //                  their ships are. 
        public void printBoard(bool withShips = false)
        {
            string currCoord; // current coordinate 
            // nested loop to go through every grid
            PrintColumnHeaders();
            for (int row = 0; row < this.numRows; row++)
            {
                for (int col = -1; col < this.numCols; col++)
                {
                    if (col == -1)
                    {
                        // print header row
                        PrintRowHeader(row);
                    }
                    else
                    {
                        currCoord = this.rowHeaders[row] + this.colHeaders[col];
                        PrintCell(currCoord);
                    }
                }
                PrintRowSeparator();
            }

        }


    }
}

