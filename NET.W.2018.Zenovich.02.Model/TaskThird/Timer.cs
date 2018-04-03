using NET.W._2018.Zenovich._02.API.TaskThird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NET.W._2018.Zenovich._02.Model.TaskThird
{
    /// <summary>
    /// Calculate time of any operation.
    /// </summary>
    public class Timer : ITimer
    {
        private Stopwatch stopwatch;

        public Timer()
        {
            stopwatch = new Stopwatch();
        }

        /// <summary>
        /// Get time span from timer.
        /// </summary>
        /// <returns></returns>
        public TimeSpan GetTime()
        {
            return stopwatch.Elapsed;
        }

        /// <summary>
        /// Starts timer.
        /// </summary>
        public void Start()
        {
            stopwatch.Reset();
            stopwatch.Start();
        }

        /// <summary>
        /// Stops timer.
        /// </summary>
        public void Stop()
        {
            stopwatch.Stop();
        }
    }
}
