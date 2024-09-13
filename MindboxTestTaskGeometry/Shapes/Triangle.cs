namespace MindboxTestTaskGeometry.Shapes;

public class Triangle: Shape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    public override double CalculateArea()
    {
        throw new NotImplementedException();
    }
    
    public bool IsRightAngled()
    {
        throw new NotImplementedException();
    }
}