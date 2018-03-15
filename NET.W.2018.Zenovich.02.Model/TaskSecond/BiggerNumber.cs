using NET.W._2018.Zenovich._02.API.TaskSecond;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Zenovich._02.Model.TaskSecond
{
    public class BiggerNumber : IBiggerNumber
    {
        private int _indexLeft;
        private int _indexRight;
        private string _number;
        private int _length;
        

        public BiggerNumber()
        {
            _indexLeft = -1;
            _indexRight = -1;
            _number = null;
            _length = -1;
        }

        public int FindNextBiggerNumber(int number)
        {
            _number = Convert.ToString(number);
            _length = _number.Length;

            FindReplacedLeftAndRightDigit();

            if (_indexLeft != -1 && _indexRight != -1)
            {
                string result = SwapAndSort();

                return Convert.ToInt32(result);
            }

            return -1;
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

        public String SwapAndSort()
        {
            char[] array = _number.ToCharArray();
            Swap(array, _indexLeft, _indexRight);

            Array.Sort(array, _indexLeft + 1, _length - _indexLeft - 1);

            return new string(array);
        }

        public void Swap<T>(T[] array, int left, int right)
        {
            T temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
