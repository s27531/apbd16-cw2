internal class Program
{
    private static void Main(string[] args)
    {
        // Feature: Create ship
        Ship ship = new(20, 100, 40_000);

        try
        {
            // Feature: Create new container
            var container1 = new LiquidContainer(100, 1, 10, 10_000, true);
            // Feature: Load the container
            container1.Load(2024);

            // Do it two times more.
            var container2 = new GasContainer(50, 0.5, 5, 5_000);
            container2.Load(3214);
            var container3 = new ColdContainer(125.5, 1.25, 13, 12_512, "bananas", 15.08);
            container3.Load(12312);

            // Feature: container on the ship
            ship.Load(container1);
            // Do it again two times more
            ship.Load(container2);
            ship.Load(container3);

            ship.Show();

            // Feature: Remove container from the ship
            ship.Unload(container2.SerialNumber);
            // Feature: Unload the container.
            container2.Empty();

            // Feature: Replace container
            ship.Unload(container3.SerialNumber);
            ship.Load(container2);

            // Feature: Move container between the ships
            Ship secondShip = new(50, 2, 30_000);
            secondShip.Load(container3);

            // Feature: Show info about the ship
            ship.Show();

            // Feature: Show info about the container
            Console.WriteLine(container3.ToString());

            // Should throw an exception.
            container2.Load(99_999_999);
        } 
        catch(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Source} : {ex.Message}");   
        }
    }
}