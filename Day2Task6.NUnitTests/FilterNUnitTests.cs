using System;
using NUnit.Framework;

namespace Day2Task6.NUnitTests
{
    [TestFixture]
    public class FilterNUnitTests
    {
        [TestCase(-10)]
        [TestCase(-1)]
        [TestCase(10)]
        [TestCase(int.MaxValue)]
        [TestCase(int.MinValue)]
        public void FilterDigitNUnitTest_DigitLessThan0AndMoreThan9_ThrowsException(int digit)
        {
            int[] array = new int[] { 7, 1, 2, 3, 4, 5, 6, 68, 69, 70, 15, 17 };
            Assert.Throws<ArgumentOutOfRangeException>(() => Filter.FilterDigit(array, digit));
        }

        [TestCase(1)]
        [TestCase(9)]
        public void FilterDigitNUnitTest_AcceptsEmptyArray_ThrowsException(int digit)
        {
            int[] array = new int[0];
            Assert.Throws<ArgumentNullException>(() => Filter.FilterDigit(array, digit));
        }

        [Test]
        public void FilterDigitNUnitTest1()
        {
            CollectionAssert.AreEqual(new int[] { 7, 70, 17 }, Filter.FilterDigit(new int[] { 7, 1, 2, 3, 4, 5, 6, 68, 69, 70, 15, 17 }, 7));
        }
              
        [TestCase(new int[] { 2, 1, 12, 3, 4, 5, 6, 68, 629, 70, 15, 17 }, 2, ExpectedResult = new int[] { 2, 12, 629 })]
        [TestCase(new int[] { 1, 1, 1 }, 2, ExpectedResult = null)]
        public int[] FilterDigitNUnitTest2(int[] arr, int filter) => Filter.FilterDigit(arr, filter);

        [Test, TestCaseSource(typeof(DataForTests), "TestCases")]
        public int[] FilterDigitNUnitTest3(int[] arr, int filter) => Filter.FilterDigit(arr, filter);
    }
}