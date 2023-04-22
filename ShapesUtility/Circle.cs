namespace ShapesUtility;

public class Circle: Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be more then 0");
        
        Radius = radius;
    }
    
    public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
}