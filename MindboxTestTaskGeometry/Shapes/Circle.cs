using System.Globalization;

namespace MindboxTestTaskGeometry.Shapes;

public class Circle: Shape
{
    public double Radius { get; set; }
    
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException(radius.ToString(CultureInfo.InvariantCulture));
        
        Radius = radius;
    }
    
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}