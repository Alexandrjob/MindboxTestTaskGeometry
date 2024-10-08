﻿namespace MindboxTestTaskGeometry.Shapes;

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
        double p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }
    
    public bool IsRightAngled()
    {
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }
}