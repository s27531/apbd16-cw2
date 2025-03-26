internal class Program
{
    private static void Main(string[] args)
    {
        Ship ship = new Ship(20, 100, 40_000);

        try
        {
            var container1 = new LiquidContainer(100, 1, 10, 10_000, true);
            container1.Load(2024);
            var container2 = new GasContainer(50, 0.5, 5, 5_000);
            container2.Load(3214);
            var container3 = new ColdContainer(125.5, 1.25, 13, 12_512, "bananas", 15.08);
            container3.Load(12312);

            ship.Load(container1);
            ship.Load(container2);
            ship.Load(container3);

            ship.Show();

            ship.Unload(container2.SerialNumber);
            ship.Show();

            // Should throw an exception.
            container2.Load(99_999_999);
        } 
        catch(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Source} : {ex.Message}");   
        }
    }
}