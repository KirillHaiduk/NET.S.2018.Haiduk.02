using System;
using System.Text;

namespace Day2Tasks1And5
{
    /// <summary>
    /// Class contains methods to operate with bits and numbers
    /// </summary>
    public class NumberMethods
    {
        #region InsertNumber method
        /// <summary>
        /// Method that inserts bits of one number into another
        /// </summary>
        /// <param name="first">Number in which bits will be inserted</param>
        /// <param name="second">Bits of this number will be inserted</param>
        /// <param name="i">Start position index</param>
        /// <param name="j">End position index</param>
        /// <returns>Integer with inserted bits of second number into first number</returns>
        public static int InsertNumber(int first, int second, int i, int j)
        {
            if (first > 15 || second > 15 || first < 8 || second < 8)
            {
                throw new ArgumentOutOfRangeException($"{nameof(first)} and {nameof(second)} must be from 8 to 15.");
            }

            if (i > j)
            {
                throw new ArgumentOutOfRangeException($"{nameof(i)} must be less or equal {nameof(j)}.");
            }

            int medium = ((2 << (j - i)) - 1) << i;
            return (first & ~medium) | ((second << i) & medium);
        }
        #endregion

        #region FindNextBiggerNumber method
        /// <summary>
        /// Method that accepts a number and calculates next bigger number using its digits
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Next bigger number to given, or -1 if it doesn't exist</returns>
        public static int FindNextBiggerNumber(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(number)} must be positive.");
            }
                        
            int[] numberArray = new int[number.ToString().Length];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(number.ToString()[i].ToString());
            }

            if (HasNoBiggerNumber(numberArray))
            {
                return -1;
            }
            
            for (int i = numberArray.Length - 1; i >= 0; i--)
            {
                if (numberArray[i] > numberArray[i - 1])
                {
                    Swap(ref numberArray[i], ref numberArray[i - 1]);
                    break;
                }
            }

            StringBuilder stringBuilder = new StringBuilder();
            foreach (int i in numberArray)
            {
                stringBuilder.Append(i);
            }

            return int.Parse(stringBuilder.ToString());
        }

        #region Private methods
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static bool HasNoBiggerNumber(int[] array)
        {
            int a = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    a++;
                }
            }

            if (a == array.Length - 1)
            {
                return true;
            }

            return false;
        }
        #endregion
        #endregion
    }
}
