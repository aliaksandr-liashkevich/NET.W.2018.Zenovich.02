using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._02.API.TaskSecond
{
    public interface IBiggerNumber
    {
        int FindNextBiggerNumber(int number);
        int FindNextBiggerNumber(int number, ref TimeSpan timeSpan);
    }
}
