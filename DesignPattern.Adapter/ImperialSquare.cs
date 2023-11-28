using DesignPattern.Adapter.Interfaces;

namespace DesignPattern.Adapter;

public class ImperialSquare : IImperialSquare
{
    private readonly double _length;

    public ImperialSquare(double length)
    {
        _length = length;
    }
    
    public double GetAreaInFeet()
    {
        return Math.Round(_length * _length, 2);
    }
}