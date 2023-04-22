namespace ShapesUtility;

public class Triangle: Shape
{
    public double A { get; }
    
    public double B { get; }
    
    public double C { get; }

    public Triangle(double a, double b, double c)
    {
        if (a <= Constants.Tolerance || b <= Constants.Tolerance || c <= Constants.Tolerance)
            throw new ArgumentException("The sides must be more then 0");
        
        if (a + b - c <= Constants.Tolerance || a + c - b <= Constants.Tolerance || b + c - a <= Constants.Tolerance)
            throw new ArgumentException("The sum of any two sides must be more than the third");

        A = a;
        B = b;
        C = c;
    }

    public override double CalculateArea()
    {
        var halfPerimeter = CalculatePerimeter() / 2;

        return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
    }

    private double CalculatePerimeter() => A + B + C;

    public bool IsRightTriangle()
    {
        return Math.Abs(Math.Pow(A, 2) - (Math.Pow(B, 2) + Math.Pow(C, 2))) < Constants.Tolerance ||
               Math.Abs(Math.Pow(B, 2) - (Math.Pow(A, 2) + Math.Pow(C, 2))) < Constants.Tolerance ||
               Math.Abs(Math.Pow(C, 2) - (Math.Pow(B, 2) + Math.Pow(A, 2))) < Constants.Tolerance;
    }
}