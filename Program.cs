using ShipTester = TestShips.ShipTester;

internal class Program
{
    private static void Main(string[] args)
    {
        ShipTester st = new ShipTester();
        st.testShipConstructors();
    }
}