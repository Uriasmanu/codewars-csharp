namespace Solution 
{
    using MinhaBiblioteca;
    using NUnit.Framework;
  using System;

  [TestFixture]
  public class KataTests
  {
    [Test, Order(1)]
    public void BasicTests()
    {
      Assert.That(Kata.IsVow(new object[] { 118,117,120,121,117,98,122,97,120,106,104,116,113,114,113,120,106 }), Is.EqualTo(new object[] { 118, "u",120,121,"u",98,122,"a",120,106,104,116,113,114,113,120,106 }));
      Assert.That(Kata.IsVow(new object[] { 101,121,110,113,113,103,121,121,101,107,103 }), Is.EqualTo(new object[] { "e",121,110,113,113,103,121,121,"e",107,103 }));
    }
  }
}
