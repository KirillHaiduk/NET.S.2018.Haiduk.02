using System;
using Day2Tasks1And5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2Task1.Tests
{
    [TestClass]
    public class NumberMethodsTests
    {
        [TestMethod]
        public void InsertNumberTest1()
        {
            Assert.AreEqual(NumberMethods.InsertNumber(15, 15, 0, 0), 15);
        }

        [TestMethod]
        public void InsertNumberTest2()
        {
            Assert.AreEqual(NumberMethods.InsertNumber(8, 15, 0, 0), 9);
        }

        [TestMethod]
        public void InsertNumberTest3()
        {
            Assert.AreEqual(NumberMethods.InsertNumber(8, 15, 3, 8), 120);
        }

        [TestMethod]
        public void InsertNumberTest_BitILessThanBitJ_ThrowsException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => NumberMethods.InsertNumber(9, 10, 5, 3));
        }

        [TestMethod]
        public void InsertNumberTest_NumbersLessThan8_ThrowsException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => NumberMethods.InsertNumber(7, 10, 2, 3));
        }

        public void InsertNumberTest_NumbersMoreThan15_ThrowsException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => NumberMethods.InsertNumber(9, 16, 0, 3));
        }
    }
}
