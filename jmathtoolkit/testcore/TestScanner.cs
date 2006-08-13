using System;
using NUnit.Framework;
using JMathToolkit.Core;
using JMathToolkit.Core.Exceptions;

namespace TestCore
{
    [TestFixture]
    public class TestScanner
    {
        [Test]
        [ExpectedException(typeof(NullStringException))]
        public void TestScannerWithNull()
        {
            Scanner.ParseString(null);
        }

        [Test]
        [ExpectedException(typeof(EmptyStringException))]
        public void TestScannerWithEmptyString()
        {
            Scanner.ParseString("");
        }

        public void StringContainingSpaces(int i)
        {
            switch (i)
            {
                case 1: Scanner.ParseString(" ");
                    break;
                case 2: Scanner.ParseString("1+2+ 3");
                    break;
                case 3: Scanner.ParseString("1+2 ");
                    break;
                case 4: Scanner.ParseString("1+2 +3 ");
                    break;
            }
        }

        [Test]
        public void TestScannerWithStringContainingSpaces()
        {
            try
            {
                StringContainingSpaces(1);
                Assert.Fail();
            }
            catch (StringContainsSpaceException e)
            {
                Assert.IsTrue(true);
            }

            try
            {
                StringContainingSpaces(2);
                Assert.Fail();
            }
            catch (StringContainsSpaceException e)
            {
                Assert.IsTrue(true);
            }

            try
            {
                StringContainingSpaces(3);
                Assert.Fail();
            }
            catch (StringContainsSpaceException e)
            {
                Assert.IsTrue(true);
            }

            try
            {
                StringContainingSpaces(4);
                Assert.Fail();
            }
            catch (StringContainsSpaceException e)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
