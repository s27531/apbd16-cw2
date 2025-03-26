class Container(double height, double weight, double depth, double maxLoad, string containerType)
{
    private static int Counter { get; set; } = 0;
    public double LoadMass { get; set; } = 0;
    public double Height { get; } = height;
    public double Weight { get; } = weight;
    public double Depth { get; } = depth;
    public string SerialNumber { get; } = $"KON-{containerType}-{Counter++}";
    public double MaxLoad { get; } = maxLoad;

    public void Empty() 
    {
        LoadMass = 0;
    }

    public virtual void Load(double mass)
    { 
        if (LoadMass + mass > MaxLoad)
        {
            throw new OverfillException();
        }
        LoadMass += mass;
    }
}

class OverfillException : Exception {}