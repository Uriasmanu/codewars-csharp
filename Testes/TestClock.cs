using MinhaBiblioteca;
using NUnit.Framework;
using System;

[TestFixture]
public class ClockTest
{
    [Test]
    public void Test()
    {
        Assert.That(Clock.Past(0, 1, 1), Is.EqualTo(61000));
    }
}
