namespace Solution 
{
    using MinhaBiblioteca;
    using NUnit.Framework;
  using System;

  [TestFixture]
  public class CalculatorTest
  {
    [Test, Description("should calculate the result of valid inputs"), Order(1)]
    public void Test()
    {
      Assert.That(Kata.Calculator(6, 2, '+'), Is.EqualTo(8));
      Assert.That(Kata.Calculator(4, 3, '-'), Is.EqualTo(1));
      Assert.That(Kata.Calculator(5, 5, '*'), Is.EqualTo(25));
      Assert.That(Kata.Calculator(5, 4, '/'), Is.EqualTo(1.25));
    }
    
    [Test, Description("should throw ArgumentException with invalid inputs"), Order(2)]
    public void ErrorTest()
    {
      Assert.That(() => Kata.Calculator(6, 2, '&'), Throws.ArgumentException);
    }
  }
}
