﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System;
using MinhaBiblioteca;


namespace Testes
{
    internal class TestArrayPlusArray
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void BasicTest()
            {
                Assert.That(KataArrayPlusArray.ArrayPlusArray(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }), Is.EqualTo(21));
                Assert.That(KataArrayPlusArray.ArrayPlusArray(new int[] { -1, -2, -3 }, new int[] { -4, -5, -6 }), Is.EqualTo(-21));
                Assert.That(KataArrayPlusArray.ArrayPlusArray(new int[] { 0, 0, 0 }, new int[] { 4, 5, 6 }), Is.EqualTo(15));
                Assert.That(KataArrayPlusArray.ArrayPlusArray(new int[] { 100, 200, 300 }, new int[] { 400, 500, 600 }), Is.EqualTo(2100));

            }
        }
    }
}
