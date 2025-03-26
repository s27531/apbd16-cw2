class LiquidContainer(double height, double weight, double depth, double maxLoad, bool isHazadous) : Container(height, weight, depth, maxLoad, "L")
{
    // TODO: ADD IHAZARDNOTIFIER

    public bool IsHazadrous { get; } = isHazadous;

    public override void Load(double mass)
    {
        double maxAllowed = IsHazadrous ? MaxLoad * 0.5 : MaxLoad * 0.9;
        if (LoadMass + mass > maxAllowed)
        {
            // TODO: USER IHAZARDNOTIFIER
            return;
        }
        LoadMass += mass;
    }
}