using System;
using System.Collections.Generic;

namespace Day2Task6
{    
    /// <summary>
    /// The filtering class
    /// </summary>
    public class Filter
    {
        #region Public members
        /// <summary>
        /// Method which takes an array of integers and filters it so that only numbers containing the given digit remain on the output
        /// </summary>
        /// <param name="array">array that is necessary to filter</param>
        /// <param name="digit">filtering digit</param>
        /// <returns>Array of integers containing filtering digit</returns>
        public static int[] FilterDigit(int[] array, int digit)
        {
            if (digit > 9 || digit < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(digit)} must be from 0 to 9");
            }

            if (array.Length == 0)
            {
                throw new ArgumentNullException($"{nameof(array)} is empty.");
            }

            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (ContainsDigit(array[i], digit))
                {
                    list.Add(array[i]);
                }
            }

            if (list.Count == 0)
            {
                return null;
            }

            return list.ToArray();
        }
        #endregion

        #region Private members
        /// <summary>
        /// Method which returns if accepted item of array contains digit
        /// </summary>
        /// <param name="item">Item of given array</param>
        /// <param name="digit">Filtering digit</param>
        /// <returns>True or false depending on whether item contains digit</returns>
        private static bool ContainsDigit(int item, int digit)
        {
            int temp = item;

            for (int i = 0; i < item.ToString().Length; i++)
            {
                var divisionResult = temp / 10;
                int remainder = temp % 10;
                temp = divisionResult;
                if (Math.Abs(remainder) == digit)
                {
                    return true;
                }
            }

            return false;
        }
        #endregion
    }
}
