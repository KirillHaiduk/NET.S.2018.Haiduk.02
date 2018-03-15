using NUnit.Framework;

namespace Day2Task6.NUnitTests
{
    [TestFixture]
    public class FilterTests
    {
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
