namespace Solution 
{
  using NUnit.Framework;
  using MinhaBiblioteca;


    [TestFixture]
  public class Tests
  {
    [Test]
    public void BasicTests()
    {
      Assert.That(KataPlural.Plural(0), Is.EqualTo(true), "Plural for 0");
      Assert.That(KataPlural.Plural(0.5), Is.EqualTo(true), "Plural for 0.5");
      Assert.That(KataPlural.Plural(1), Is.EqualTo(false), "Plural for 1");
      Assert.That(KataPlural.Plural(100), Is.EqualTo(true), "Plural for 100");
      Assert.That(KataPlural.Plural(double.PositiveInfinity), Is.EqualTo(true), "Plural for Infinity");      
    }
  }
}
