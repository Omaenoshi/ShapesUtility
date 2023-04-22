namespace ShapesUtility.Tests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void NegativeSideOrZero_InConstructor_ArgumentExceptionExpected()
    {
        var message = "The sides must be more then 0";
        Assert.ThrowsException<ArgumentException>(() => {
            new Triangle(-1, 2, 3);
        }, message);
        Assert.ThrowsException<ArgumentException>(() => {
            new Triangle(2, -1, 3);
        }, message);
        Assert.ThrowsException<ArgumentException>(() => {
            new Triangle(3, 2, -3);
        }, message);
        Assert.ThrowsException<ArgumentException>(() => {
            new Triangle(0, -2, -3);
        }, message);
    }
    
    [TestMethod]
    public void NonExistentTriangle_InConstructor_ArgumentExceptionExpected()
    {
        var message = "The sum of any two sides must be more than the third";
        
        Assert.ThrowsException<ArgumentException>(() => {
            new Triangle(5, 2, 3);
        }, message);
        Assert.ThrowsException<ArgumentException>(() => {
            new Triangle(5, 2, 7);
        }, message);
        Assert.ThrowsException<ArgumentException>(() => {
            new Triangle(5, 8, 3);
        }, message);
    }

    [TestMethod]
    public void CalculateArea_3and4and5_6returned()
    {
        double a = 3, b = 4, c = 5;
        var expected = 6;

        var triangle = new Triangle(a, b, c);
        var actual = triangle.CalculateArea();
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void IsRightTriangle_3and4and5_TrueReturned()
    {
        double a = 3, b = 4, c = 5;
        var expected = true;

        var triangle = new Triangle(a, b, c);
        var actual = triangle.IsRightTriangle();
        
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void IsRightTriangle_3and7and5_FalseReturned()
    {
        double a = 3, b = 7, c = 5;
        var expected = false;

        var triangle = new Triangle(a, b, c);
        var actual = triangle.IsRightTriangle();
        
        Assert.AreEqual(expected, actual);
    }
}