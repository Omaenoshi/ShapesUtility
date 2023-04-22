namespace ShapesUtility.Tests;

using ShapesUtility;

[TestClass]
public class CircleTests
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentException),
        "Radius must be more then 0")]
    public void NegativeRadius_InConstructor_ArgumentExceptionExpected()
    {
        new Circle(-1);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentException),
        "Radius must be more then 0")]
    public void ZeroRadius_InConstructor_ArgumentExceptionExpected()
    {
        var circle = new Circle(0);
    }
    
    [TestMethod]
    public void CalculateArea_5radius_78and54returned()
    {
        var radius = 5;
        var expected = 78.54d;
        var tolerance = 0.05;

        var circle = new Circle(radius);
        var actual = circle.CalculateArea();
        
        Assert.AreEqual(expected, actual, tolerance);
    }
    
    [TestMethod]
    public void CalculateArea_10radius_314returned()
    {
        var radius = 10;
        var expected = 314;
        var tolerance = 0.5;

        var circle = new Circle(radius);
        var actual = circle.CalculateArea();
        
        Assert.AreEqual(expected, actual, tolerance);
    }
}