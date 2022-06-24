using ST = TestShips.ShipTester;
using PBT = TestPlayerBoard.PlayerBoardTester;
internal class Program
{
    private static void Main(string[] args)
    {
        ST st = new ST();
        PBT pbt = new PBT();

        st.testShipConstructors();
        pbt.PrintHitsAndMissesTest();
    }
}