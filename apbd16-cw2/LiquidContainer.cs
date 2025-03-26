class LiquidContainer(double height, double weight, double depth, double maxLoad, bool isHazadous) : Container(height, weight, depth, maxLoad, "L"), IHazardNotifier
{
    public bool IsHazadrous { get; } = isHazadous;

    public override void Load(double mass)
    {
        double maxAllowed = IsHazadrous ? MaxLoad * 0.5 : MaxLoad * 0.9;
        if (LoadMass + mass > maxAllowed)
        {
            Notify("Attempt exceeds allowed load!");
            return;
        }
        if (LoadMass + mass > MaxLoad)
        {
            throw new OverfillException();
        }
        LoadMass += mass;
    }

    public void Notify(string message)
    {
        Console.WriteLine($"DANGER: {message} (Container: {SerialNumber})");
    }
}