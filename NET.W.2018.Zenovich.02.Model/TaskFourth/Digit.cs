using NET.W._2018.Zenovich._02.API.TaskFourth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._02.Model.TaskFourth
{
    public class Digit : IDigit
    {
        public int[] FilterDigit(int number, params int[] arguments)
        {
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
