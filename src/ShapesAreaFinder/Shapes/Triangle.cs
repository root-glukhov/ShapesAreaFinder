namespace ShapesAreaFinder.Shapes;

public class Triangle : Shape
{
    public double Side1 { get; }
    public double Side2 { get; }
    public double Side3 { get; }

    public Triangle(double side1, double side2, double side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public override double GetArea()
    {
        double p = (Side1 + Side2 + Side3) / 2;
        return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
    }

    public bool IsRectangular()
    {
        if (Side1 > Side2 && Side1 > Side3)
        {
            return Math.Pow(Side1, 2) == Math.Pow(Side2, 2) + Math.Pow(Side3, 2);
        }
        else if (Side2 > Side1 && Side2 > Side3)
        {
            return Math.Pow(Side2, 2) == Math.Pow(Side1, 2) + Math.Pow(Side3, 2);
        }
        else
        {
            return Math.Pow(Side3, 2) == Math.Pow(Side1, 2) + Math.Pow(Side2, 2);
        }
    }
}
