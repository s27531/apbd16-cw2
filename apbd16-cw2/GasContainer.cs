class GasContainer(double height, double weight, double depth, double maxLoad) : Container(height, weight, depth, maxLoad, "G"), IHazardNotifier
{

    public override void Empty()
    {
        LoadMass *= 0.05;
    }

    public void Notify(string message)
    {
        Console.WriteLine($"DANGER: {message} (Container: {SerialNumber})");
    }
}
