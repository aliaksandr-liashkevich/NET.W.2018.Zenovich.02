using NET.W._2018.Zenovich._02.API.TaskSecond;
using NET.W._2018.Zenovich._02.API.TaskThird;
using NET.W._2018.Zenovich._02.Model.TaskThird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._02.Model.TaskSecond
{
    /// <summary>
    /// Allows to seek for a next bigger number to specified value.
    /// </summary>
    public class BiggerNumber : IBiggerNumber
    {
        private int _indexLeft;
        private int _indexRight;
        private string _number;
        private int _length;

        private ITimer _timer;

        protected ITimer Timer
        {
            get
            {
                if (_timer == null)
                {
                    _timer = new Timer();
                }   

                return _timer;
            }
            set
            {
                _timer = value ?? throw new ArgumentNullException(nameof(Timer));
            }
        }

        public BiggerNumber()
        {
            _indexLeft = -1;
            _indexRight = -1;
            _number = null;
            _length = -1;
        }

        /// <summary>
        /// Finds the next bigger number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>The next bigger number.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="number"/> is less than 0.
        /// </exception>
        /// <exception cref="OverflowException">
        /// The result is bigger than <paramref cref="int.MaxValue"/>.
        /// </exception>
        public int FindNextBiggerNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            _number = Convert.ToString(number);
            _length = _number.Length;

            FindReplacedLeftAndRightDigit();

            if (_indexLeft != -1 && _indexRight != -1)
            {
                int result = -1;

                if (Int32.TryParse(SwapAndSort(), out result))
                {
                    return result;
                }

                throw new OverflowException($"The FindNextBiggerNumber method result  is bigger than {Int32.MaxValue}");
            }

            return -1;
        }

        /// <summary>
        /// Finds the next bigger number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="timeSpan">The time span.</param>
        /// <returns>The next bigger number.</returns>
        public int FindNextBiggerNumber(int number, ref TimeSpan timeSpan)
        {
            int result;
            Timer.Start();
            try
            {
                result = FindNextBiggerNumber(number);
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                Timer.Stop();
            }

            timeSpan = Timer.GetTime();

            return result;
        }

        private void FindReplacedLeftAndRightDigit()
        {
            int currentValue = -1;

            for (int i = _length - 1; i >= 0; i--)
            {
                currentValue = _number[i];
                for (int j = _length - 1; j >= i; j--)
                {
                    if (_number[j] > currentValue)
                    {
                        _indexLeft = i;
                        _indexRight = j;

                        return;
                    }
                }
            }

            _indexLeft = -1;
            _indexRight = -1;
        }

        private String SwapAndSort()
        {
            char[] array = _number.ToCharArray();
            Swap(array, _indexLeft, _indexRight);

            Array.Sort(array, _indexLeft + 1, _length - _indexLeft - 1);

            return new string(array);
        }

        private void Swap<T>(T[] array, int left, int right)
        {
            T temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
