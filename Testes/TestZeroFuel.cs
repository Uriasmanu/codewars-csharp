namespace Solution 
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    [Order(1)]
    public void SampleTest()
    {
      Assert.That(KataZeroFuel.ZeroFuel(50, 25, 2), Is.True);
      Assert.That(KataZeroFuel.ZeroFuel(100, 50, 1), Is.False);
    }
  }
}