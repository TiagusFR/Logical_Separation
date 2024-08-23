using Logical_Separation;

public class Program
{
    public void Main (string[] args)
    {
        var cartesianPoint = Point.Factory.NewCartesianPoint(2, 3);
        var polarPoint = Point.Factory.NewPolarPoint(5, Math.PI / 4);
    }
}