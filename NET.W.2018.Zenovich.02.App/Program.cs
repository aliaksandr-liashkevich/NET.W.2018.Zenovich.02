using NET.W._2018.Zenovich._02.API.TaskFourth;
using NET.W._2018.Zenovich._02.API.TaskSecond;
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
            IDigit digit = new Digit();
            int[] array = digit.FilterDigit(7, 1, 2, 3, 4, 5, 7, 68, 69, 70, 15, 17);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
