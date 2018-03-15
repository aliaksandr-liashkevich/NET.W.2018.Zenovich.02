using NET.W._2018.Zenovich._02.API.TaskSecond;
using NET.W._2018.Zenovich._02.Model.TaskSecond;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._02.App
{
    class Program
    {
        static void Main(string[] args)
        { 
            BiggerNumber bigger = new BiggerNumber();
            int result = bigger.FindNextBiggerNumber(20);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
