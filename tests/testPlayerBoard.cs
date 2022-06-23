// this file is to test the player board functionality
using playerBoard = PlayerBoard.PlayerBoard;
namespace TestPlayerBoard
{
    public class PlayerBoardTester
    {
        public void PrintPlayerBoardTest()
        {
            playerBoard PB = new playerBoard();
            PB.printBoard();
        }
    }
}