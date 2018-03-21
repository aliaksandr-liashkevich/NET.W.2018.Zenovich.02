using NET.W._2018.Zenovich._02.API.TaskFifth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._02.Model.TaskFifth
{
    /// <summary>
    /// allows to get sqrt of number
    /// </summary>
    public class SqrtCalculator : ISqrt
    {
        private double Pow(double number, int n)
        {
            double result = 1;

            for (int i = 0; i < n; i++)
            {
                result *= number;
            }

            return result;
        }

        public double functionXkPlus1(double n, double x0, double number)
        {
            return (1 / n) * ((n - 1) * x0 + number / Pow(x0, (int)n - 1));
        }

        /// <summary>
        /// implementations sqrt algorithm for number
        /// </summary>
        /// <param name="number">number will be used in sqrt calculation</param>
        /// <param name="n">power in sqrt calculation</param>
        /// <param name="eps">accuracy</param>
        /// <returns>nth root of number</returns>
        public double SqrtN(double number, int n, double eps)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }

            if (eps < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(eps));
            }

            double x0 = number / n;
            double xkPlus1 = functionXkPlus1(n, x0, number);
            
            while (Math.Abs(xkPlus1 - x0) > eps)
            {
                x0 = xkPlus1;
                xkPlus1 = functionXkPlus1(n, x0, number);
            }

            return xkPlus1;
        }
    }
}
