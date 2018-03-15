using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._02.API.TaskThird
{
    public interface ITimer
    {
        void Start();
        void Stop();
        TimeSpan GetTime();
    }
}
