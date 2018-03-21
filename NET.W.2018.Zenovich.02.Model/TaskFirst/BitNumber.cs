using NET.W._2018.Zenovich._02.API.TaskFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._02.Model.TaskFirst
{
    /// <summary>
    /// allows to get inserted number from j-th to i-th bits
    /// </summary>
    public class BitNumber : IBitNumber
    {
        private int GetBitNumberOfUnits(int number)
        {
            return int.MaxValue >> (30 - number);
        }

        private int LeftShift(int value, int left)
        {
            return value << left;
        }

        private int GetInsertedNumber(int jUnits, int shift)
        {
            return jUnits & shift;
        }

        /// <summary>
        /// replace specific btis of a number from j-th to i-th bits
        /// </summary>
        /// <param name="leftValue">source number</param>
        /// <param name="rightValue">inserted number</param>
        /// <param name="i">from</param>
        /// <param name="j">to</param>
        /// <returns></returns>
        public int InsertNumber(int leftValue, int rightValue, int i, int j)
        {
            if (i < 0 || i > 31)
            {
                throw new ArgumentOutOfRangeException(nameof(i));
            }

            if (j < 0 || j > 31)
            {
                throw new ArgumentOutOfRangeException(nameof(j));
            }

            if (i > j)
            {
                throw new ArgumentOutOfRangeException(nameof(i));
            }

            int jUnits = GetBitNumberOfUnits(j);
            int shift = LeftShift(rightValue, i);

            int result = GetInsertedNumber(jUnits, shift) | leftValue;

            return result;
        }
    }
}
