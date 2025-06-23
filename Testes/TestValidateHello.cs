using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

[TestFixture]
public class Test
{
    [Test]
    public void Test1()
    {
        Assert.That(Kata.ValidateHello("hello"), Is.True);
        Assert.That(Kata.ValidateHello("ciao bella!"), Is.True);
        Assert.That(Kata.ValidateHello("salut"), Is.True);
        Assert.That(Kata.ValidateHello("hallo, salut"), Is.True);
        Assert.That(Kata.ValidateHello("hombre! Hola!"), Is.True);
        Assert.That(Kata.ValidateHello("Hallo, wie geht's dir?"), Is.True);
        Assert.That(Kata.ValidateHello("AHOJ!"), Is.True);
        Assert.That(Kata.ValidateHello("czesc"), Is.True);
        Assert.That(Kata.ValidateHello("Ahoj"), Is.True);
        Assert.That(Kata.ValidateHello("meh"), Is.False);
    }
}