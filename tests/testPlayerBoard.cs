// this file is to test the player board functionality
using playerBoard = PlayerBoard.PlayerBoard;
using ship = Ship.Ship;

namespace TestPlayerBoard
{
    public class PlayerBoardTester
    {
        // function to test how board looks when printed
        public void PrintPlayerBoardTest()
        {
            Console.WriteLine("##### Testing Player Board Print ##### \n");
            playerBoard PB = new playerBoard();
            PB.setDebug(true);
            PB.printBoard();
        }

        // test if board is printing hits and misses correctly
        public void PrintHitsAndMissesTest()
        {
            Console.WriteLine("##### Testing Player Board Print with hits and misses #####");
            playerBoard PB = new playerBoard();
            PB.setDebug(false);

            Console.WriteLine("Adding arbitrary hits...");
            string[] hits = { "A1", "A2", "A3", "A4", "A5" };
            Console.Write("Hits: ");
            hits.ToList().ForEach(i =>
            {
                Console.Write(i.ToString() + " ");
                PB.addHit(i);
            });
            Console.WriteLine("\n");


            Console.WriteLine("Adding arbitrary misses...");
            string[] misses = { "C4", "D4", "E4", "F4", "G4" };
            Console.Write("Misses: ");
            misses.ToList().ForEach(i =>
            {
                Console.Write(i.ToString() + " ");
                PB.addMiss(i);
            });
            Console.WriteLine("\n");


            PB.printBoard();
        }
    }


}