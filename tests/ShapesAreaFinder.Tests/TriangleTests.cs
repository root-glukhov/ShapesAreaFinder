using ShapesAreaFinder.Shapes;

namespace ShapesAreaFinder.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 6, 7, 14.70)]
    public void GetArea_ShouldCalculateAreaCorrectly(double side1, double side2, double side3, double expectedArea)
    {
        Triangle triangle = new Triangle(side1, side2, side3);
        double actualArea = triangle.GetArea();

        Assert.Equal(expectedArea, actualArea, precision: 2);
    }

    [Theory]
    [InlineData(1, 2, 3, false)]
    [InlineData(3, 4, 5, true)]
    public void IsRectangular_ShouldReturnCorrectValue(double side1, double side2, double side3, bool expectedValue)
    {
        Triangle triangle = new Triangle(side1, side2, side3);
        bool actualValue = triangle.IsRectangular();

        Assert.Equal(expectedValue, actualValue);
    }
}