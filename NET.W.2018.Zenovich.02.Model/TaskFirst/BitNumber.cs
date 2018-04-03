using NET.W._2018.Zenovich._02.API.TaskFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._02.Model.TaskFirst
{
    /// <summary>
    /// Allows to get inserted number from j-th to i-th bits
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
        /// Insert <paramref name="rightValue" /> into <paramref name="leftValue" /> from <paramref name="j" />-th to <paramref name="i" />-th bit.
        /// </summary>
        /// <param name="leftValue">A int number source.</param>
        /// <param name="rightValue">A int inserted number.</param>
        /// <param name="i">Position to.</param>
        /// <param name="j">Position from.</param>
        /// <returns>
        /// Result of inserting <paramref name="rightValue" /> into <paramref name="leftValue" />.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="i"/> is less than 0 or great than 31
        /// or
        /// <paramref name="j"/> is less than 0 or great than 31
        /// or
        /// <paramref name="i"/> is great than <paramref name="j"/>.
        /// </exception>
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
