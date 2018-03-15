using NET.W._2018.Zenovich._02.API.TaskSecond;
using NET.W._2018.Zenovich._02.Model.TaskSecond;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._02.App
{

    class Program
    {
        static void Main(string[] args)
        {
            BiggerNumber biggerNumber = new BiggerNumber();
            TimeSpan timeSpan = new TimeSpan();

            Thread.Sleep(1000);

            Console.WriteLine(biggerNumber.FindNextBiggerNumber(123232, ref timeSpan));
            Console.WriteLine(timeSpan.TotalMilliseconds);

            Console.WriteLine(biggerNumber.FindNextBiggerNumber(123232, ref timeSpan));
            Console.WriteLine(timeSpan.TotalMilliseconds);

            Console.ReadKey();
        }
    }
}
