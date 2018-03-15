using NET.W._2018.Zenovich._02.API.TaskThird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NET.W._2018.Zenovich._02.Model.TaskThird
{
    public class Timer : ITimer
    {
        private Stopwatch stopwatch;

        public Timer()
        {
            stopwatch = new Stopwatch();
        }

        public TimeSpan GetTime()
        {
            return stopwatch.Elapsed;
        }

        public void Start()
        {
            stopwatch.Reset();
            stopwatch.Start();
        }

        public void Stop()
        {
            stopwatch.Stop();
        }
    }
}
