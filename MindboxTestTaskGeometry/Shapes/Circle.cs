namespace MindboxTestTaskGeometry.Shapes;

public class Circle: Shape
{
    public double Radius { get; set; }
    
    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public override double CalculateArea()
    {
        throw new NotImplementedException();
    }
}