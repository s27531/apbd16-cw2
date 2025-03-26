class Ship(double maxSpeed, int maxContainerCount, double maxContainerWeight)
{
    private List<Container> Containers { get; } = [];
    public double MaxSpeed { get; } = maxSpeed;
    public int MaxContainerCount { get; } = maxContainerCount;
    public double MaxContainerWeight { get; } = maxContainerWeight;

    public void Load(Container container) 
    {
        if (Containers.Count >= MaxContainerCount)
        {
            throw new Exception("Ship capacity exceeded.");
        }
        if (Containers.Sum(c => c.LoadMass) + container.LoadMass > MaxContainerWeight * 1000) // Tone to Kilograms conversion
        {
            throw new Exception("Ship weight capacity exceeded.");
        }
        Containers.Add(container);
    }

    public void Unload(string serialNumber)
    {
        Container? container = Containers.FirstOrDefault(c => c.SerialNumber == serialNumber);
        if (container is not null)
        {
            Containers.Remove(container);
        }
    }

    public void Show()
    {
        Console.WriteLine("==========");
        Console.WriteLine("Ship info:");
        Console.WriteLine("==========");
        foreach (var container in Containers)
        {
            Console.WriteLine($"\t{container}");
        }
    }
}