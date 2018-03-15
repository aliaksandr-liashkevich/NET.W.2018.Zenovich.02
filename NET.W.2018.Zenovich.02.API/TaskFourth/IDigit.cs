using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._02.API.TaskFourth
{
    public interface IDigit
    {
        int[] FilterDigit(int number, params int[] arguments);
    }
}
