using ShapesAreaFinder.Shapes;

namespace ShapesAreaFinder.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(1, Math.PI)]
    [InlineData(5, 78.54)]
    public void GetArea_ShouldCalculateAreaCorrectly(double radius, double expectedArea)
    {
        Circle circle = new Circle(radius);
        double actualArea = circle.GetArea();

        Assert.Equal(expectedArea, actualArea, precision: 2);
    }
}
