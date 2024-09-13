using MindboxTestTaskGeometry.Factory;
using MindboxTestTaskGeometry.Shapes;

namespace MindboxTestTaskGeometry_Tests;

public class ShapeFactoryTests
{
    [Fact]
    public void CreateCircle_ReturnsCircleInstance()
    {
        var shape = ShapeFactory.CreateCircle(5);

        Assert.IsType<Circle>(shape);
    }

    [Fact]
    public void CreateTriangle_ReturnsTriangleInstance()
    {
        var shape = ShapeFactory.CreateTriangle(3, 4, 5);

        Assert.IsType<Triangle>(shape);
    }
}