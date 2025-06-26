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
        Assert.That(KataHellow.ValidateHello("hello"), Is.True);
        Assert.That(KataHellow.ValidateHello("ciao bella!"), Is.True);
        Assert.That(KataHellow.ValidateHello("salut"), Is.True);
        Assert.That(KataHellow.ValidateHello("hallo, salut"), Is.True);
        Assert.That(KataHellow.ValidateHello("hombre! Hola!"), Is.True);
        Assert.That(KataHellow.ValidateHello("Hallo, wie geht's dir?"), Is.True);
        Assert.That(KataHellow.ValidateHello("AHOJ!"), Is.True);
        Assert.That(KataHellow.ValidateHello("czesc"), Is.True);
        Assert.That(KataHellow.ValidateHello("Ahoj"), Is.True);
        Assert.That(KataHellow.ValidateHello("meh"), Is.False);
    }
}