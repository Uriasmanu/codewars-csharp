using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace Testes
{
    internal class TestRemoveChar
    {
        [Test, Order(1)]
        public void Test1()
        {
            Assert.That(KataRemoveChar.Remove_char("eloquent"), Is.EqualTo("loquen").IgnoreCase);
            Assert.That(KataRemoveChar.Remove_char("country"), Is.EqualTo("ountr").IgnoreCase);
            Assert.That(KataRemoveChar.Remove_char("person"), Is.EqualTo("erso").IgnoreCase);
            Assert.That(KataRemoveChar.Remove_char("place"), Is.EqualTo("lac").IgnoreCase);
            Assert.That(KataRemoveChar.Remove_char("ok"), Is.EqualTo("").IgnoreCase);
        }
    }
}
