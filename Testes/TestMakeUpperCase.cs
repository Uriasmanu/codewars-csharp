using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;
using NUnit.Framework;



namespace Testes

{
    [TestFixture]
    internal class TestMakeUpperCase
    {
        [Test]
        public void BasicTest()
        {
            Assert.That(KataMakeUpperCase.MakeUpperCase("hello"), Is.EqualTo("HELLO"));
        }
    }
}
