using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Zenovich._02.API.TaskSecond;
using NET.W._2018.Zenovich._02.Model.TaskSecond;

namespace NET.W._2018.Zenovich._02.Tests.TaskSecond
{
    [TestClass]
    public class BiggerNumberTest
    {
        public TestContext TestContext
        {
            get;
            set;
        }

        private static IBiggerNumber biggerNumber;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            biggerNumber = new BiggerNumber();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "Numbers.xml",
            "Number",
            DataAccessMethod.Sequential)]
        [DeploymentItem("TaskSecond\\Files\\Numbers.xml")]
        public void FindNextBiggerNumber_NumberFromXml_ExpectedFromXml()
        {
            // arrange
            int number = Convert.ToInt32(TestContext.DataRow["number"].ToString());
            int expected = Convert.ToInt32(TestContext.DataRow["expected"].ToString());

            // act
            int actual = biggerNumber.FindNextBiggerNumber(number);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindNextBiggerNumber_0Number_Minus1Returned()
        {
            // arrange
            int number = 0;
            int expected = -1;

            // act
            int actual = biggerNumber.FindNextBiggerNumber(number);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindNextBiggerNumber_30Number_132Returned()
        {
            // arrange
            int number = 123;
            int expected = 132;

            // act
            int actual = biggerNumber.FindNextBiggerNumber(number);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FindNextBiggerNumber_Minus30Number_ArgumentOutOfRangeException()
        {
            // arrange
            int number = -30;

            // act
            int actual = biggerNumber.FindNextBiggerNumber(number);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void FindNextBiggerNumber_2147483641Number_OverflowException()
        {
            // arrange
            int number = 2147483641;

            // act
            int actual = biggerNumber.FindNextBiggerNumber(number);
        }
    }
}
