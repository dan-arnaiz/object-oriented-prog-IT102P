public class DistanceCalculator
{
    private double originX;
    private double originY;

    public static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }

    public void SetOrigin(double x, double y)
    {
        this.originX = x;
        this.originY = y;
    }

    public double CalculateDistanceFromOrigin(double x, double y)
    {
        return CalculateDistance(this.originX, this.originY, x, y);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        DistanceCalculator calculator = new DistanceCalculator();
        calculator.SetOrigin(0, 0);

        double distance = calculator.CalculateDistanceFromOrigin(5, 5);
        Console.WriteLine($"Distance from origin to point (5,5) is {distance}");

        distance = DistanceCalculator.CalculateDistance(1, 1, 4, 5);
        Console.WriteLine($"Distance between points (1,1) and (4,5) is {distance}");
    }
}