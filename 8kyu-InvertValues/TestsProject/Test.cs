using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _8kyu_InvertValues
{
    [TestFixture]
    class Test
    { 
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new int[] { -1, -2, -3, -4, -5 }, ArraysInversion.InvertValues(new int[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(new int[] { -1, 2, -3, 4, -5 }, ArraysInversion.InvertValues(new int[] { 1, -2, 3, -4, 5 }));
            Assert.AreEqual(new int[] { }, ArraysInversion.InvertValues(new int[] { }));
            Assert.AreEqual(new int[] { 0 }, ArraysInversion.InvertValues(new int[] { 0 }));
        }
    }
}
