using ShapesAreaFinder.Shapes;

var circle = new Circle(5);
var triangle = new Triangle(5, 6, 7);

Console.WriteLine($"Circle: {circle.GetArea().ToString("F2")}");
Console.WriteLine($"Triangle: {triangle.GetArea().ToString("F2")}; IsRectangular: {triangle.IsRectangular()}");
Console.Read();