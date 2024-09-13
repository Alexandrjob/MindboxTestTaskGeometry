using MindboxTestTaskGeometry.Shapes;

namespace MindboxTestTaskGeometry_Tests;

public class TriangleTests
{
    [Fact]
    public void CalculateArea_ReturnsCorrectArea()
    {
        var triangle = new Triangle(3, 4, 5);
        var expectedArea = 6;

        var actualArea = triangle.CalculateArea();

        Assert.Equal(expectedArea, actualArea, 0.0001);
    }

    [Fact]
    public void IsRightAngled_RightAngledTriangle_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);

        var isRightAngled = triangle.IsRightAngled();

        Assert.True(isRightAngled);
    }

    [Fact]
    public void IsRightAngled_NotRightAngledTriangle_ReturnsFalse()
    {
        var triangle = new Triangle(3, 4, 6);

        var isRightAngled = triangle.IsRightAngled();

        Assert.False(isRightAngled);
    }
}