using System;
using System.Collections.Generic;

namespace Day2Task6
{
    /// <summary>
    /// The filtering class
    /// </summary>
    public class Filter
    {
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
                throw new ArgumentOutOfRangeException($"{nameof(digit)} must be from 0 to 9.");
            }

            if (array.Length == 0)
            {
                throw new ArgumentNullException($"{nameof(array)} is empty.");
            }

            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].ToString().Contains(digit.ToString()))
                {
                    list.Add(array[i]);
                }
            }

            if (list.Count == 0)
            {
                return null;
            }
            else
            {
                return list.ToArray();
            }
        }
    }
}
