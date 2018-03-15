using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Zenovich._02.API.TaskFifth;
using NET.W._2018.Zenovich._02.Model.TaskFifth;

namespace NET.W._2018.Zenovich._02.Tests.TaskFifth
{
    [TestClass]
    public class SqrtCalculatorTest
    {
        public TestContext TestContext { get; set; }

        private static ISqrt sqrtCaculator;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            sqrtCaculator = new SqrtCalculator();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
        "Numbers.xml",
        "Number",
        DataAccessMethod.Sequential)]
        [DeploymentItem("TaskFifth\\Files\\Numbers.xml")]
        public void SqrtN_NumberFromXml_ExpectedFromXml()
        {
            // arrange
            double number = Convert.ToDouble(TestContext.DataRow["number"].ToString(), CultureInfo.InvariantCulture);
            int n = Convert.ToInt32(TestContext.DataRow["n"].ToString());
            double eps = Convert.ToDouble(TestContext.DataRow["eps"].ToString(), CultureInfo.InvariantCulture);
            double expected = Convert.ToDouble(TestContext.DataRow["expected"].ToString(), CultureInfo.InvariantCulture);

            // act
            double actual = sqrtCaculator.SqrtN(number, n, eps);

            // assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void SqrtN_8Number3N_0point1Eps_2Returend()
        {
            // arrange
            double number = 8;
            int n = 3;
            double eps = 0.01;
            double expected = 2;

            // act
            double actual = sqrtCaculator.SqrtN(number, n, eps);

            // assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void SqrtN_8Number15N_Minus7Eps_ArgumentOutOfRangeException()
        {
            // arrange
            double number = 8;
            int n = 15;
            double eps = -7;

            // act
            double actual = sqrtCaculator.SqrtN(number, n, eps);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void SqrtN_8NumberMinus15N_0point6Eps_ArgumentOutOfRangeException()
        {
            // arrange
            double number = 8;
            int n = -15;
            double eps = 0.6;

            // act
            double actual = sqrtCaculator.SqrtN(number, n, eps);
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void SqrtN_8Number15N_Minus0point6Eps_ArgumentOutOfRangeException()
        {
            // arrange
            double number = 8;
            int n = 15;
            double eps = -0.6;

            // act
            double actual = sqrtCaculator.SqrtN(number, n, eps);
        }
    }
}
