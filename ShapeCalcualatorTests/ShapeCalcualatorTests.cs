using NUnit.Framework;

[TestFixture]
public class ShapeCalcualatorTests
{
    ShapeCalculator calculator;

    [SetUp]
    public void Setup()
    {
       calculator = new ShapeCalculator();
    }

    [Test]
    public void TestCalculateCircleArea()
    {
        Assert.AreEqual(78.54, calculator.CalculateCircleArea(5), 0.01);
    }

    [Test]
    public void TestCalculateTriangleArea()
    {
        Assert.AreEqual(6, calculator.CalculateTriangleArea(3, 4, 5));
    }

    [Test]
    public void TestIsRightTriangle()
    {
        Assert.IsTrue(calculator.IsRightTriangle(3, 4, 5));
        Assert.IsFalse(calculator.IsRightTriangle(4, 5, 6));
    }
}