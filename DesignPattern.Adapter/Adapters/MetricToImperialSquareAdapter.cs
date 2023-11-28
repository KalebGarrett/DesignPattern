using DesignPattern.Adapter.Interfaces;

namespace DesignPattern.Adapter.Adapters;

public class MetricToImperialSquareAdapter : IImperialSquare
{
    private readonly IMetricSquare _metricSquare;
    
    public MetricToImperialSquareAdapter(IMetricSquare metricSquare)
    {
        _metricSquare = metricSquare;
    }

    public double GetAreaInFeet()
    {
        var areaInSquareMeters = _metricSquare.GetAreaInMeters();
        var areaInSquareFeet = areaInSquareMeters * 3.281;
        return Math.Round(areaInSquareFeet, 2);
    }
}