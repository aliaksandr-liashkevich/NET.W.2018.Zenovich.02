using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._02.API.TaskFirst
{
    public interface IBitNumber
    {
        /// <summary>
        /// Insert <paramref name="rightValue"/> into <paramref name="leftValue"/> from <paramref name="j"/>-th to <paramref name="i"/>-th bit
        /// </summary>
        /// <returns>
        /// Result of inserting <paramref name="rightValue"/> into <paramref name="leftValue"/
        /// </returns>
        /// <param name="leftValue">A int number source</param>
        /// <param name="rightValue">A int inserted number</param>
        /// <param name="i">Position to</param>
        /// <param name="j">Position from</param>
        /// <returns></returns>
        int InsertNumber(int leftValue, int rightValue, int i, int j);
    }
}
