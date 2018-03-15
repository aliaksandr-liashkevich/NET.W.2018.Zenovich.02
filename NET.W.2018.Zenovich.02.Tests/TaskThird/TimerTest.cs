using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.W._2018.Zenovich._02.API.TaskThird;
using NET.W._2018.Zenovich._02.Model.TaskThird;

namespace NET.W._2018.Zenovich._02.Tests.TaskFourth
{
    [TestClass]
    public class TimerTest
    {
        [TestMethod]
        public void GetTime_TimeIsBiggerThan0()
        {
            ITimer timer = new Timer();

            timer.Start();
            System.Threading.Thread.Sleep(10);
            timer.Stop();

            Assert.IsTrue(timer.GetTime().Ticks > 0, "The Ticks was not greater than 0");
        }

        [TestMethod]
        public void GetTime_TimeIsBiggerThan1000()
        {
            ITimer timer = new Timer();

            timer.Start();
            System.Threading.Thread.Sleep(1000);
            timer.Stop();

            Debug.WriteLine($"Ticks: {timer.GetTime().TotalSeconds}");
            Assert.IsTrue(timer.GetTime().TotalSeconds >= 1, "The Ticks was not greater than 1000");
        }
    }
}
