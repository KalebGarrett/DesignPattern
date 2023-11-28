using DesignPattern.Adapter.Interfaces;

namespace DesignPattern.Adapter.Adapters;

public class ImperialToMetricSquareAdapter : IMetricSquare
{
    private readonly ImperialSquare _imperialSquare;

    public ImperialToMetricSquareAdapter(ImperialSquare imperialSquare)
    {
        _imperialSquare = imperialSquare;
    }

    public double GetAreaInMeters()
    {
        var areaInSquareFeet = _imperialSquare.GetAreaInFeet();
        var areaInSquareMeters = areaInSquareFeet / 3.281;
        return Math.Round(areaInSquareMeters, 2);
    }
}