using DesignPattern.Adapter;
using DesignPattern.Adapter.Adapters;

var squareAreaInFeet = new ImperialSquare(3);
Console.WriteLine($"Area in feet: {squareAreaInFeet.GetAreaInFeet()}");

var convertSquareAreaToMeters = new ImperialToMetricSquareAdapter(squareAreaInFeet);
Console.WriteLine($"Area converted to meters: {convertSquareAreaToMeters.GetAreaInMeters()}\n");

var squareAreaInMeters = new MetricSquare(7);
Console.WriteLine($"Area in meters: {squareAreaInMeters.GetAreaInMeters()}");

var convertSquareToFeet = new MetricToImperialSquareAdapter(squareAreaInMeters);
Console.WriteLine($"Area converted to feet: {convertSquareToFeet.GetAreaInFeet()}");

