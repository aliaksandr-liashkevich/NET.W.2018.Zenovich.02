using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NET.W._2018.Zenovich._02.API.TaskSecond;
using NET.W._2018.Zenovich._02.API.TaskThird;
using NET.W._2018.Zenovich._02.Model.TaskSecond;

namespace NET.W._2018.Zenovich._02.Tests.TaskThird
{
    [TestClass]
    public class BiggerNumberTest
    {
        private IBiggerNumber biggerNumber;
        private Mock<ITimer> timer;

        public class DerivedBiggerNumber : BiggerNumber
        {
            public DerivedBiggerNumber(ITimer timer)
            {
                Timer = timer;
            }
        }

        [TestInitialize]
        public void MethodInitialize()
        {
            timer = new Mock<ITimer>();
            biggerNumber = new DerivedBiggerNumber(timer.Object);
        }


        [TestMethod]
        public void FindNextBiggerNumber_TimerCallStart()
        {
            int number = 123;
            var timeSpan = new TimeSpan();

            timer.Setup(t => t.Start());

            biggerNumber.FindNextBiggerNumber(number, ref timeSpan);

            timer.VerifyAll();
        }

        [TestMethod]
        public void FindNextBiggerNumber_TimerCallGetTime()
        {
            int number = 123213;
            var timeSpan = new TimeSpan();

            timer.Setup(t => t.GetTime());

            biggerNumber.FindNextBiggerNumber(number, ref timeSpan);
            

            timer.VerifyAll();
        }

        [TestMethod]
        public void FindNextBiggerNumber_TimerCallStop()
        {
            int number = 123;
            var timeSpan = new TimeSpan();

            timer.Setup(t => t.Stop());

            biggerNumber.FindNextBiggerNumber(number, ref timeSpan);

            timer.VerifyAll();
        }
    }
}
