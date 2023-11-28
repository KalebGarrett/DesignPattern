using DesignPattern.Adapter.Interfaces;

namespace DesignPattern.Adapter;

public class MetricSquare : IMetricSquare
{
    private readonly double _length;

    public MetricSquare(double length)
    {
        _length = length;
    }
    
    public double GetAreaInMeters()
    {
        return Math.Round(_length * _length, 2);
    }
}