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
        /// <param name="arr">array that is necessary to filter</param>
        /// <param name="filter">filtering digit</param>
        /// <returns>Array of integers containing filtering digit</returns>
        public static int[] FilterDigit(int[] arr, int filter)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToString().Contains(filter.ToString()))
                {
                    list.Add(arr[i]);
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