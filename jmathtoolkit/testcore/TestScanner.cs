using System;
using NUnit.Framework;
using JMathToolkit.Core;

namespace TestCore
{
    [TestFixture]
    public class TestScanner
    {
        [Test]
        [ExpectedException(typeof(System.Exception))]
        public void TestScannerWithNull()
        {
            Scanner.ParseString(null);
        }

        [Test]
        [ExpectedException(typeof(System.Exception))]
        public void TestScannerWithEmptyString()
        {
            Scanner.ParseString("");
        }

    }
}
