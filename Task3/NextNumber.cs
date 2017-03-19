using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// Contains the methods for working with integer numbers
    /// </summary>
    public class NextNumber
    {
        #region Public methods
        /// <summary>
        /// Takes a positive integer and returns the next bigger integer consisting of the digits of the source number, and - 1, if such number doesn't exist
        /// </summary>
        /// <param name="number">Source positive integer for calculations</param>
        /// <returns>Next bigger integer number from the source number</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int NextBiggerNumber(int number)
        {
            if (number < 0 || number >= int.MaxValue)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number <= 11)
            {
                return -1;
            }

            return Next(number);
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Finds the next bigger integer consisting of the digits of the source number
        /// </summary>
        /// <param name="number">Source number</param>
        /// <returns>Next bigger integer number from the source number</returns>
        private static int Next(int number)
        {
            int[] buff = new int[number.ToString().Length];
            for (int i = buff.Length - 1; i > -1; i--)
            {
                buff[i] = number % 10;
                number /= 10;
            }

            int index = FindIndex(buff);
           
            if (index == -1)
            {
                return -1;
            }

            int temp;

            if (index < buff.Length - 1)
            {
                temp = buff[index];
                buff[index] = buff[index+1];
                buff[index+1] = temp;
                Array.Sort(buff, index+1, buff.Length - index - 1);
            }

            int result = 0;
            for (int i = 0; i < buff.Length; i++)
            {
                result += (int)(buff[i] * Math.Pow(10, buff.Length - 1 - i));
            }

            return result;
        }

        /// <summary>
        /// Finds index of the numeral in the array starting with which the number should be sorted
        /// </summary>
        /// <param name="temp">Array consisting of numerals of the source number</param>
        /// <returns>Index of the numeral in the number starting with which the number should be changed or -1, if this is not possible</returns>
        private static int FindIndex(int[] temp)
        {
            for (int i = temp.Length - 1; i > 0; i--)
            {
                if (temp[i] > temp[i - 1])
                {
                    return (i - 1);
                }
            }
            return -1;
        }
        #endregion

    }
}
