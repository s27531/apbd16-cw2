using System;
using System.Collections.Generic;

class ColdContainer : Container
{
    private static Dictionary<string, double> products = new Dictionary<string, double>
    {
        { "bananas", 13.3 },
        { "chocolate", 18 },
        { "fish", 2 },
        { "meat", -15 },
        { "ice cream", -18 },
        { "frozen pizza", -30 },
        { "cheese", -7.2 },
        { "sausages", 5 },
        { "butter", 20.5 },
        { "eggs", 19 }
    };

    public string ContentType { get; }
    public double Temperature { get; }

    
    public ColdContainer(double height, double weight, double depth, double maxLoad, string contentType, double temperature) : base(height, weight, depth, maxLoad, "C")
    {
        if (!products.ContainsKey(contentType))
        {
            throw new Exception($"Unsupported product type: {contentType}.");
        }
        double minTemperature = products[contentType];
        if (temperature < minTemperature)
        {
            throw new Exception($"Given temperature '{temperature}' exceeds minimal temperature threshold '{minTemperature}'.");
        }

        ContentType = contentType;
        Temperature = temperature;
    }

}