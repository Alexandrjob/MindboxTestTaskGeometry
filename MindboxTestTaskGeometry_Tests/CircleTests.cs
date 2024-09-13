using MindboxTestTaskGeometry.Shapes;

namespace MindboxTestTaskGeometry_Tests;

public class CircleTests
{
    [Fact]
    public void CalculateArea_ReturnsCorrectArea()
    {
        var circle = new Circle(5);
        var expectedArea = Math.PI * 25;

        var actualArea = circle.CalculateArea();

        Assert.Equal(expectedArea, actualArea, 0.0001);
    }

    [Fact]
    public void Constructor_NegativeRadius_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => {
            new Circle(-1);
        });
    }
}