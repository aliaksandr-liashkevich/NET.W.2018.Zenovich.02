using NET.W._2018.Zenovich._02.API.TaskFourth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._02.Model.TaskFourth
{
    /// <summary>
    /// filters integer number array.
    /// </summary>
    public class Digit : IDigit
    {
        /// <summary>
        /// allows to filter array numbers.
        /// </summary>
        /// <param name="number">number that will be used to filter the array.</param>
        /// <param name="arguments">Array of integer</param>
        /// <returns>Filtered array</returns>
        public int[] FilterDigit(int number, params int[] arguments)
        {
            
            if (arguments == null)
            {
                throw new ArgumentNullException(nameof(arguments));
            }

            List<int> list = new List<int>();

            Regex regex = new Regex($"[{number}]");
            foreach (int item in arguments)
            {
                if (regex.IsMatch(item.ToString()))
                {
                    list.Add(item);
                }
            }

            return list.ToArray();
        }
    }
}
