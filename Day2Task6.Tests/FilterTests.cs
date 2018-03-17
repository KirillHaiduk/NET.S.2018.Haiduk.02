using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2Task6.Tests
{
    [TestClass]
    public class FilterTests
    {
        [TestMethod]
        public void FilterDigitTest1()
        {
            // Arrange
            int[] unfiltered = { 7, 1, 2, 3, 4, 5, 6, 68, 69, 70, 15, 17 };

            // Act
            int[] filtered = Filter.FilterDigit(unfiltered, 7);

            // Assert
            CollectionAssert.AreEqual(new int[] { 7, 70, 17 }, filtered);
        }

        [TestMethod]
        public void FilterDigitTest2()
        {
            // Arrange
            int[] unfiltered = { 12, 1, 2, 0, 4, 5, 60, 68, 69, 79, 15, 108 };

            // Act
            int[] filtered = Filter.FilterDigit(unfiltered, 0);

            // Assert
            CollectionAssert.AreEqual(new int[] { 0, 60, 108 }, filtered);
        }
    }
}
