using NET.W._2018.Zenovich._02.API.TaskFifth;
using NET.W._2018.Zenovich._02.API.TaskFourth;
using NET.W._2018.Zenovich._02.API.TaskSecond;
using NET.W._2018.Zenovich._02.Model.TaskFifth;
using NET.W._2018.Zenovich._02.Model.TaskFourth;
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
            ISqrt sqrt = new SqrtCalculator();
            double result = sqrt.SqrtN(0.04100625, 4, 0.0001);

            Console.ReadKey();
        }
    }
}
