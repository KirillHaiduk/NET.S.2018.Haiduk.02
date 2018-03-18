using System;
using NUnit.Framework;

namespace Day2Tasks1And5.NUnitTests
{
    [TestFixture]
    public class NumberMethodsNUnitTests
    {
        [TestCase(16, 8, 1, 2)]
        [TestCase(13, 0, 0, 0)]
        [TestCase(int.MaxValue, 8, 1, 2)]
        [TestCase(10, int.MinValue, 1, 2)]
        public void InsertNumberNUnitTest_NumbersLessThan8OrMoreThan15_ThrowsException(int first, int second, int i, int j)
        {            
            Assert.Throws<ArgumentOutOfRangeException>(() => NumberMethods.InsertNumber(first, second, i, j));
        }

        [TestCase(10, 12, 2, 1)]
        public void InsertNumberNUnitTest_BitILessThanBitJ_ThrowsException(int first, int second, int i, int j)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => NumberMethods.InsertNumber(first, second, i, j));
        }

        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        public int InsertNumberNUnitTest1(int first, int second, int i, int j)
        {
            return NumberMethods.InsertNumber(first, second, i, j);
        }

        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(2077, ExpectedResult = 2707)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        public int FindNextBiggerNumberNUnitTest1(int number)
        {
            return NumberMethods.FindNextBiggerNumber(number);
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(int.MinValue)]
        public void FindNextBiggerNumberNUnitTest_NumberNotPositive_ThrowsException(int number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => NumberMethods.FindNextBiggerNumber(number));
        }
    }
}
