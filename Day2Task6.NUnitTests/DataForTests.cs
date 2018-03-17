using System.Collections;
using NUnit.Framework;

namespace Day2Task6.NUnitTests
{
    /// <summary>
    /// Class that contains data for NUnit Tests
    /// </summary>
    public class DataForTests
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2, 3, 4, 22, 33, 44, 55 }, 3).Returns(new int[] { 3, 33 });
                yield return new TestCaseData(new int[] { 1, 2, 3, 4, 22, 33, 44, 55 }, 8).Returns(null);
                yield return new TestCaseData(new int[] { 1, 2, 3, 4, 22, 3223, 44, 5522, 2621, 223 }, 2).Returns(new int[] { 2, 22, 3223, 5522, 2621, 223 });
            }
        }
    }
}
