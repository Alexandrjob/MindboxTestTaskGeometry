using MindboxTestTaskGeometry.Factory;
using MindboxTestTaskGeometry.Services;
using MindboxTestTaskGeometry.Shapes;

namespace MindboxTestTaskGeometry_Tests;

public class GeometryCalculatorTests
{
    [Fact]
    public void CalculateArea_Circle_ReturnsCorrectArea()
    {
        var circle = ShapeFactory.CreateCircle(5);
        var expectedArea = Math.PI * 25;

        var actualArea = GeometryCalculator.CalculateArea(circle);

        Assert.Equal(expectedArea, actualArea, 0.0001);
    }

    [Fact]
    public void CalculateArea_Triangle_ReturnsCorrectArea()
    {
        var triangle = ShapeFactory.CreateTriangle(3, 4, 5);
        var expectedArea = 6;

        var actualArea = GeometryCalculator.CalculateArea(triangle);

        Assert.Equal(expectedArea, actualArea, 0.0001);
    }

    [Fact]
    public void IsTriangleRightAngled_RightAngledTriangle_ReturnsTrue()
    {
        var triangle = (Triangle)ShapeFactory.CreateTriangle(3, 4, 5);

        var isRightAngled = GeometryCalculator.IsTriangleRightAngled(triangle);

        Assert.True(isRightAngled);
    }

    [Fact]
    public void IsTriangleRightAngled_NotRightAngledTriangle_ReturnsFalse()
    {
        var triangle = (Triangle)ShapeFactory.CreateTriangle(3, 4, 6);

        var isRightAngled = GeometryCalculator.IsTriangleRightAngled(triangle);

        Assert.False(isRightAngled);
    }
}