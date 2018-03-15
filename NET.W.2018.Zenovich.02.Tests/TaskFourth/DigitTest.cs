using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Zenovich._02.API.TaskFourth;
using NET.W._2018.Zenovich._02.Model.TaskFourth;

namespace NET.W._2018.Zenovich._02.Tests.TaskThird
{
    [TestClass]
    public class DigitTest
    {
        public TestContext TestContext
        {
            get;
            set;
        }

        private static IDigit digit;
        private int[] arguments;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            digit = new Digit();
        }

        [TestMethod]
        public void FilterDigit_7Number_Contain3Numbers()
        {
            int number = 7;
            int[] arguments = new int[]
            {
                1, 2, 3, 7, 2, 5, 71, 90, 17
            };
            int[] expected = new int[]
            {
                7, 71, 17
            };

            int[] actual = digit.FilterDigit(number, arguments);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterDigit_7Number_Contains0Number()
        {
            int number = 7;
            int[] arguments = new int[]
            {
                1, 2, 3, 3, 5, 90
            };

            int[] expected = new int[0];


            int[] actual = digit.FilterDigit(number, arguments);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterDigit_2Number_ContainsExpected()
        {
            int number = -2;
            int[] arguments = new int[]
            {
                2, 2, 2, 0, 24, 42
            };

            int[] expected = new int[]
            {
                2, 2, 2
            };

            int[] actual = digit.FilterDigit(number, arguments);

            CollectionAssert.IsSubsetOf(expected, actual);
        }

        [TestMethod]
        public void FilterDigit_Minus2Number_EqualExpected()
        {
            int number = -2;
            int[] arguments = new int[]
            {
                1, -2, 3, 3, -25
            };

            int[] expected = new int[]
            {
                -2, -25
            };

            int[] actual = digit.FilterDigit(number, arguments);

            CollectionAssert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void FilterDigit_7Number_NullArguments_ArgumentNullException()
        {
            int number = 7;
            int[] arguments = null;

            int[] expected = new int[0];


            int[] actual = digit.FilterDigit(number, arguments);
        }
    }
}
