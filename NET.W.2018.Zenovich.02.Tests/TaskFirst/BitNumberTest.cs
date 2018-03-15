using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Zenovich._02.API.TaskFirst;
using NET.W._2018.Zenovich._02.Model.TaskFirst;

namespace NET.W._2018.Zenovich._02.Tests.TaskFirst
{
    [TestClass]
    public class BitNumberTest
    {
        private static BitNumber bitNumber;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            bitNumber = new BitNumber();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumber_Minus32LefValue_ArgumentOutOfRangeException()
        {
            int leftValue = -32;
            int rightValue = 44;

            int i = 0;
            int j = 0;

            bitNumber.InsertNumber(leftValue, rightValue, i, j);
        }

        [TestMethod]
        public void InsertNumber_15into8PostionsI3J8_120returned()
        {
            // arrange
            int leftValue = 8;
            int rightValue = 15;

            int i = 3;
            int j = 8;

            int expected = 120;

            // act
            int actual = bitNumber.InsertNumber(leftValue, rightValue, i, j);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertNumber_15into8PostionsI3J5_56returned()
        {
            // arrange
            int leftValue = 8;
            int rightValue = 15;

            int i = 3;
            int j = 5;

            int expected = 56;

            // act
            int actual = bitNumber.InsertNumber(leftValue, rightValue, i, j);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertNumber_15into15PostionsI0J0_15returned()
        {
            // arrange
            int leftValue = 15;
            int rightValue = 15;

            int i = 0;
            int j = 0;

            int expected = 15;

            // act
            int actual = bitNumber.InsertNumber(leftValue, rightValue, i, j);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertNumber_15into8PostionsI0J0_9returned()
        {
            // arrange
            int leftValue = 8;
            int rightValue = 15;

            int i = 0;
            int j = 0;

            int expected = 9;

            // act
            int actual = bitNumber.InsertNumber(leftValue, rightValue, i, j);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
