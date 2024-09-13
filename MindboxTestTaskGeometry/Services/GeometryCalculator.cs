using MindboxTestTaskGeometry.Shapes;

namespace MindboxTestTaskGeometry.Services;

public class GeometryCalculator
{
    public static double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }

    public static bool IsTriangleRightAngled(Triangle triangle)
    {
        return triangle.IsRightAngled();
    }
}